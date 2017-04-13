using System;
using System.Diagnostics;
using System.Threading;
using CloudAPI.Rest.Client;
using Windows.ApplicationModel.Background;
using CloudAPI.Rest.Client.Models;
using Newtonsoft.Json.Linq;

// The Background Application template is documented at http://go.microsoft.com/fwlink/?LinkID=533884&clcid=0x409

namespace RaspberryBackground {
    public sealed class StartupTask : IBackgroundTask {

        private CloudClient client;
        private HistoricData data;
        private Random rng;
        private Timer timer;
        private int delay = 2000;
        private const int DeviceId = 2;

        public async void Run(IBackgroundTaskInstance taskInstance) {
            // 
            // Code to perform background work
            //
            // If you start any asynchronous methods here, prevent the task
            // from closing prematurely by using BackgroundTaskDeferral as
            // described in http://aka.ms/backgroundtaskdeferral
            //  

            rng = new Random();
            client = new CloudClient {BaseUri = new Uri("https://cloudtfg.azurewebsites.net")};

            var deferral = taskInstance.GetDeferral();
            try {
                await client.GetAccessToken();
            }
            catch (Exception e) {
                Debug.WriteLine(e);
            }
            
            timer = new Timer(Callback, null, 0, delay);
            //deferral.Complete();
        }

        private void Callback(object state) {
            try {
                var device = (Devices)client.GetDevices(DeviceId);

                if (device.DeviceEnabled) {
                    data = new HistoricData(DeviceId, rng.Next(20, 25).ToString(), 1);
                    var response = (JObject)client.PostData(data);
                    Debug.WriteLine(response.ToString());

                    var interval = (int)response["Interval"];
                    if (interval != delay) {
                        delay = interval;
                        timer.Change(0, delay);
                    }
                }

            }
            catch (Exception e) {
                Debug.WriteLine(e);
            }
        }
    }
}
