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
        private Random rng;
        private Timer timer;
        private int delay = 4000;
        private const int DeviceId = 2;

        private BackgroundTaskDeferral deferral;
        private GpioController GPIO;
        private GpioPin output;

        public async void Run(IBackgroundTaskInstance taskInstance) {
            // 
            // Code to perform background work
            //
            // If you start any asynchronous methods here, prevent the task
            // from closing prematurely by using BackgroundTaskDeferral as
            // described in http://aka.ms/backgroundtaskdeferral
            //  

            rng = new Random();
            initGPIO();
            client = new CloudClient {BaseUri = new Uri("https://cloudtfg.azurewebsites.net")};
            
            deferral = taskInstance.GetDeferral();
            taskInstance.Canceled += TaskInstanceOnCanceled;
            try {
                await client.GetAccessToken();
            }
            catch (Exception e) {
                Debug.WriteLine(e);
            }
            
            timer = new Timer(Callback, null, 0, delay);
        }

        private void initGPIO() {
            GPIO = GpioController.GetDefault();
            if (GPIO == null) {
                Debug.WriteLine("Cannot access Pin controller");
                return;
            }

            output = GPIO.OpenPin(5);
            output.Write(GpioPinValue.High);
            output.SetDriveMode(GpioPinDriveMode.Output);

            var value = output.Read();
            Debug.WriteLine(value);
            
        }

        private void TaskInstanceOnCanceled(IBackgroundTaskInstance sender, BackgroundTaskCancellationReason reason) {
            if (reason == BackgroundTaskCancellationReason.Terminating) {
                timer.Dispose();
                output.Dispose();
                deferral?.Complete();
            }
        }

        private async void Callback(object state) {
            try {
                var device = (Devices)client.GetDevices(DeviceId);

                if (device.DeviceEnabled) {
                    //TODO read from output pin
                    var result = await client.HttpPostData(new HistoricData(DeviceId, rng.Next(20, 25).ToString(), 1));
                    Debug.WriteLine(result.Body.ToString());

                    if (result.Response.StatusCode == HttpStatusCode.Created) {
                        var data = (JObject) result.Body;
                        var interval = (int)data["Interval"];
                        if (interval != delay) {
                            delay = interval;
                            timer.Change(0, delay);
                        }
                    }
                }

            }
            catch (Exception e) {
                Debug.WriteLine(e.Message);
            }
        }
    }
}
