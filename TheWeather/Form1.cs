using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheWeather
{
    public partial class Form1 : Form
    {
        const string APPID = "4ef63234156943cd9ade8f8e845fe62e";
        string cityName = "Turnhout";
        public Form1()
        {
            InitializeComponent();
            getWeather(cityName);
        }

        void getWeather(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&cnt=6", city, APPID);
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherInfo.Root>(json);
                WeatherInfo.Root outPut = result;

                lbl_cityName.Text = string.Format("{0}", outPut.name);
                lbl_country.Text = string.Format("{0}", outPut.sys.country);
                lbl_Temp.Text = string.Format("{0} \u00B0" + "C", outPut.main.temp);
            }
            
        }
        void getForecast(string city)
        {
            string url = "";
            using (WebClient web = new WebClient())
            {
                var json = web.DownloadString(url);
                var Object = JsonConvert.DeserializeObject<weatherForecast>(json);

                weatherForecast forecast = Object;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
