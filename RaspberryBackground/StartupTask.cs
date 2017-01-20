using System;
using System.Diagnostics;
using Windows.System.Threading;
using CloudAPI.Rest.Client;
using Windows.ApplicationModel.Background;
using CloudAPI.Rest.Client.Models;

// The Background Application template is documented at http://go.microsoft.com/fwlink/?LinkID=533884&clcid=0x409

namespace RaspberryBackground {
    public sealed class StartupTask : IBackgroundTask {

        private CloudClient client;
        private HistoricData data;
        private Random rng;
        private ThreadPoolTimer timer;
        private int delay = 5000;

        private BackgroundTaskDeferral deferral;
        public void Run(IBackgroundTaskInstance taskInstance) {
            // 
            // TODO: Insert code to perform background work
            //
            // If you start any asynchronous methods here, prevent the task
            // from closing prematurely by using BackgroundTaskDeferral as
            // described in http://aka.ms/backgroundtaskdeferral
            //
            
            deferral = taskInstance.GetDeferral();

            rng = new Random();
            client = new CloudClient {BaseUri = new Uri("https://cloudtfg.azurewebsites.net")};
            timer = ThreadPoolTimer.CreatePeriodicTimer(timer_tick, TimeSpan.FromMilliseconds(delay));
            
            //deferral.Complete();
        }

        private void timer_tick(ThreadPoolTimer tim) {
            try {
                data = new HistoricData(2, rng.NextDouble().ToString(), 1);
                var response = client.PostData(data);
                Debug.WriteLine(response.ToString());
            } catch (Exception e) {
                Debug.WriteLine(e);
            }
        }
    }
}
