﻿using Newtonsoft.Json;
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
        //const string APPID = "4ef63234156943cd9ade8f8e845fe62e";
        const string APPID = "542ffd081e67f4512b705f89d2a611b2";
        string cityName = "Geel";
        public Form1()
        {
            InitializeComponent();
            getWeather(cityName);
            getForecast(cityName);
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
            int day = 5;
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units=metric&cnt={1}&APPID={2}", city, day, APPID);
            using (WebClient web = new WebClient())
            {
                var json = web.DownloadString(url);
                var Object = JsonConvert.DeserializeObject<weatherForecast>(json);

                weatherForecast forecast = Object;

                lbl_days.Text = string.Format("{0}", getDate(forecast.list[1].dt).DayOfWeek); //returns date
                lbl_wind.Text = string.Format("{0} km/h", forecast.list[1].speed);// weather wind speed
                lbl_description.Text = string.Format("{0}", forecast.list[1].weather[0].description);// weather description
                lbl_condition.Text = string.Format("{0}", forecast.list[1].weather[0].main);// weather condition
                lbl_temp1_min.Text = string.Format("{0}\u00B0" + "C", forecast.list[1].temp.min);// weather temp min
                lbl_temp1_max.Text = string.Format("{0}\u00B0" + "C", forecast.list[1].temp.max);// weather temp max


                lbl_day2.Text = string.Format("{0}", getDate(forecast.list[2].dt).DayOfWeek); //returns date
                lbl_wind2.Text = string.Format("{0} km/h", forecast.list[2].speed);// weather wind speed
                lbl_desc2.Text = string.Format("{0}", forecast.list[2].weather[0].description);// weather description
                lbl_condition2.Text = string.Format("{0}", forecast.list[2].weather[0].main);// weather condition
                lbl_temp2_min.Text = string.Format("{0}\u00B0" + "C", forecast.list[2].temp.min);// weather temp min
                lbl_temp2_max.Text = string.Format("{0}\u00B0" + "C", forecast.list[2].temp.max);// weather temp max

            }

        }

        DateTime getDate(double millisecound)
        {

            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisecound).ToLocalTime();

            return day;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel4.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
