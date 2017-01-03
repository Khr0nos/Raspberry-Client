using System;
using System.Diagnostics;
using System.Net;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using CloudAPI.Rest.Client;
using CloudAPI.Rest.Client.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RaspberryGUI {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page {
        private CloudClient client;
        private HistoricData data;
        private Random rng;

        public MainPage() {
            this.InitializeComponent();
            rng = new Random();
            client = new CloudClient {BaseUri = new Uri("http://cloudtfg.azurewebsites.net")};
            var timer = new DispatcherTimer {Interval = TimeSpan.FromMilliseconds(5000)};
            timer.Tick += TimerOnTick;
            timer.Start();
        }

        private void TimerOnTick(object sender, object o) {
            try {
                data = new HistoricData(4, rng.NextDouble().ToString(), 1);
                var res = client.PostDataAsync(data);
                if (res.Result.Response.StatusCode == HttpStatusCode.Created) {
                    var response = res.Result.Body;
                    output.Text =
                        $"Data added:\nid: {response.IdhistoricData}\nvalue: {response.HistDataValue}\ndate: {response.HistDataDate}";
                    status.Fill = new SolidColorBrush(Colors.Green);
                } else {
                    status.Fill = new SolidColorBrush(Colors.Red);
                }
                Debug.WriteLine(res.Result.Response.StatusCode);
            } catch (Exception e) {
                Debug.WriteLine(e);
            }
        }
    }
}
