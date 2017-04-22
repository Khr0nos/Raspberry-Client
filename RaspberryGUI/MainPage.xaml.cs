using System;
using System.Diagnostics;
using System.Net;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using CloudAPI.Rest.Client;
using CloudAPI.Rest.Client.Models;
using Newtonsoft.Json.Linq;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RaspberryGUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page {
        private CloudClient client;
        private Random rng;
        private DispatcherTimer timer;
        private int delay = 5000;
        private const int DeviceId = 2;

        public MainPage()
        {
            InitializeComponent();
            try {
                rng = new Random();
                client = new CloudClient { BaseUri = new Uri("https://cloudtfg.azurewebsites.net") };

                initToken().Wait();

                timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(5000) };
                timer.Tick += TimerOnTick;
                timer.Start();
            } catch (Exception ex) {
                Debug.WriteLine(ex);
            }
        }

        private async System.Threading.Tasks.Task initToken() {
            try {
                await client.GetAccessToken();
            } catch (Exception e) {
                Debug.WriteLine(e.Message);
            }
        }

        private async void TimerOnTick(object sender, object o) {
            try {
                var device = (Devices) client.GetDevices(DeviceId);

                if (device.DeviceEnabled) {
                    var result = await client.HttpPostData(new HistoricData(DeviceId, rng.Next(20, 25).ToString(), 1));
                    Debug.WriteLine(result.Body.ToString());

                    if (result.Response.StatusCode == HttpStatusCode.Created) {
                        var data = (JObject) result.Body;
                        var interval = (int) data["Interval"];
                        if (interval != delay) {
                            delay = interval;
                            timer.Interval = TimeSpan.FromMilliseconds(delay);
                        }
                    }
                }
            } catch (Exception e) {
                Debug.WriteLine(e.Message);
            }
            //try {
            //    var data = new HistoricData(2, rng.NextDouble().ToString(), 1);
            //    var res = client.HttpPostData(data);
            //    if (res.Result.Response.StatusCode == HttpStatusCode.Created) {
            //        var added = (JObject) res.Result.Body;
            //        //output.Text =
            //        //    $"Data added:\nid: {added.IdhistoricData}\nvalue: {added.HistDataValue}\ndate: {added.HistDataDate}";
            //        status.Fill = new SolidColorBrush(Colors.Green);
            //    } else {
            //        output.Text = JsonConvert.SerializeObject(res.Result.Body);
            //        status.Fill = new SolidColorBrush(Colors.Red);
            //    }

            //    Debug.WriteLine(res.Result.Response.StatusCode);
            //} catch (Exception e) {
            //    Debug.WriteLine(e);
            //}
        }
    }
}
