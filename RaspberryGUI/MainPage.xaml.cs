﻿using System;
using System.Diagnostics;
using System.Net;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using CloudAPI.Rest.Client;
using CloudAPI.Rest.Client.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RaspberryGUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page {
        private CloudClient client;
        private HistoricData data;
        private Random rng;

        public MainPage() {
            InitializeComponent();
            rng = new Random();
            client = new CloudClient {BaseUri = new Uri("https://cloudtfg.azurewebsites.net") };
            var timer = new DispatcherTimer {Interval = TimeSpan.FromMilliseconds(5000)};
            timer.Tick += TimerOnTick;
            timer.Start();
        }

        private void TimerOnTick(object sender, object o) {
            try {
                data = new HistoricData(2, rng.NextDouble().ToString(), 1);
                var res = client.HttpPostData(data);
                if (res.Result.Response.StatusCode == HttpStatusCode.Created) {
                    var added = (JObject) res.Result.Body;
                    //output.Text =
                    //    $"Data added:\nid: {added.IdhistoricData}\nvalue: {added.HistDataValue}\ndate: {added.HistDataDate}";
                    status.Fill = new SolidColorBrush(Colors.Green);
                } else {
                    output.Text = JsonConvert.SerializeObject(res.Result.Body);
                    status.Fill = new SolidColorBrush(Colors.Red);
                }
                Debug.WriteLine(res.Result.Response.StatusCode);
            } catch (Exception e) {
                Debug.WriteLine(e);
            }
        }
    }
}
