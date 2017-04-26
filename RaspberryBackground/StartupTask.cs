using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using CloudAPI.Rest.Client;
using Windows.ApplicationModel.Background;
using Windows.Devices.Gpio;
using CloudAPI.Rest.Client.Models;
using Newtonsoft.Json.Linq;

// The Background Application template is documented at http://go.microsoft.com/fwlink/?LinkID=533884&clcid=0x409

namespace RaspberryBackground {
    public sealed class StartupTask : IBackgroundTask {
        private CloudClient client;
        //private Random rng;
        private Timer dataTimer;
        private Timer ledTimer;
        private int delay = 4000;
        private const int DeviceId = 2;
        private const int switch_pin = 2;
        private const int led_pin = 21;

        private BackgroundTaskDeferral deferral;
        private GpioController GPIO;
        private GpioPin switchPin;
        private GpioPin ledPin;

        private void initGPIO() {
            GPIO = GpioController.GetDefault();
            if (GPIO == null) {
                Debug.WriteLine("Cannot access Pin controller");
                return;
            }
            ledPin = GPIO.OpenPin(led_pin);
            ledPin.Write(GpioPinValue.Low);
            ledPin.SetDriveMode(GpioPinDriveMode.Output);

            switchPin = GPIO.OpenPin(switch_pin);
            switchPin.SetDriveMode(GpioPinDriveMode.Input);
            switchPin.DebounceTimeout = TimeSpan.FromMilliseconds(50);
            //pin.ValueChanged += (sender, args) => {
            //    Debug.WriteLine(pin.Read());
            //};

            //var value = pin.Read();
            //Debug.WriteLine(value);
        }

        public async void Run(IBackgroundTaskInstance taskInstance) {
            // 
            // Code to perform background work
            //
            // If you start any asynchronous methods here, prevent the task
            // from closing prematurely by using BackgroundTaskDeferral as
            // described in http://aka.ms/backgroundtaskdeferral
            //  

            //rng = new Random();
            initGPIO();
            client = new CloudClient {BaseUri = new Uri("https://cloudtfg.azurewebsites.net")};

            deferral = taskInstance.GetDeferral();
            taskInstance.Canceled += TaskInstanceOnCanceled;
            try {
                await client.GetAccessToken();
            } catch (Exception e) {
                Debug.WriteLine(e);
            }

            dataTimer = new Timer(DataSend, null, 0, delay);
            ledTimer = new Timer(LedFlip, null, 0, 100);
        }   

        private void TaskInstanceOnCanceled(IBackgroundTaskInstance sender, BackgroundTaskCancellationReason reason) {
            if (reason == BackgroundTaskCancellationReason.Terminating) {
                dataTimer.Dispose();
                ledTimer.Dispose();
                switchPin.Dispose();
                ledPin.Dispose();
                deferral?.Complete();
            }
        }

        private async void DataSend(object state) {
            try {
                var device = (Devices) client.GetDevices(DeviceId);

                if (device.DeviceEnabled) {
                    var switchRead = switchPin.Read();
                    Debug.WriteLine(switchRead);
                    var active_state = switchRead == GpioPinValue.Low ? "Active" : "Inactive";
                    var result = await client.HttpPostData(new HistoricData(DeviceId, active_state, 5)); //rng.Next(20, 25).ToString() type 1 type 5 == activation state
                    Debug.WriteLine(result.Body.ToString());

                    if (result.Response.StatusCode == HttpStatusCode.Created) {
                        var data = (JObject) result.Body;
                        var interval = (int) data["Interval"];
                        if (interval != delay) {
                            delay = interval;
                            dataTimer.Change(0, delay);
                        }
                    }
                }
            } catch (Exception e) {
                Debug.WriteLine(e.Message);
            }
        }

        private void LedFlip(object state) {
            var switchRead = switchPin.Read();
            //Debug.WriteLine(switchRead);
            ledPin.Write(switchRead);
        }
    }
}
