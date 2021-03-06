using Dapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace TheWeather
{
    public partial class Form1 : Form
    {
        //const string APPID = "4ef63234156943cd9ade8f8e845fe62e";
        const string APPID = "542ffd081e67f4512b705f89d2a611b2";
        string cityName = "Geel";
        public string country, currentdate;
       
        public Form1()
        {
            
            InitializeComponent();
            getWeather(cityName);
            getForecast(cityName);
            showDbData();
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        public void showDbData()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                String stn = "SELECT * FROM Data";
                SQLiteCommand cmd = new SQLiteCommand(stn, (SQLiteConnection)cnn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.DefaultView;
               
            }
        }
        public void deleteData()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Data");

            }
        }
      
       
        void getWeather(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&cnt=6", city, APPID);
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherInfo.Root>(json);
                WeatherInfo.Root outPut = result;

                lbl_cityName.Text = string.Format("{0}, " + outPut.sys.country, outPut.name);
                country = string.Format("{0}", outPut.sys.country);
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

                currentdate = string.Format("{0}", DateTime.Today.ToString("dd-MM-yy")); //returns date
                Console.WriteLine(currentdate);
                lbl_0wind.Text = string.Format("{0} km/h", forecast.list[0].speed);// weather wind speed
                //lbl_description.Text = string.Format("{0}", forecast.list[0].weather[0].description);// weather description
                lbl_cond.Text = string.Format("{0}", forecast.list[0].weather[0].main);// weather condition
                lbl_0minTemp.Text = string.Format("{0}\u00B0" + "C", forecast.list[0].temp.min);// weather temp min
                lbl_0maxTemp.Text = string.Format("{0}\u00B0" + "C", forecast.list[0].temp.max);// weather temp max

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

                lbl_day3.Text = string.Format("{0}", getDate(forecast.list[3].dt).DayOfWeek); //returns date
                lbl_wind3.Text = string.Format("{0} km/h", forecast.list[3].speed);// weather wind speed
                lbl_desc3.Text = string.Format("{0}", forecast.list[3].weather[0].description);// weather description
                lbl_condition3.Text = string.Format("{0}", forecast.list[3].weather[0].main);// weather condition
                lbl_temp3_min.Text = string.Format("{0}\u00B0" + "C", forecast.list[3].temp.min);// weather temp min
                lbl_temp3_max.Text = string.Format("{0}\u00B0" + "C", forecast.list[3].temp.max);// weather temp max
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
            button1.Enabled = false;
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel4.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel5.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel6.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cityName = txt_cityName.Text;
                getWeather(cityName);
                getForecast(cityName);
            }
            catch
            {
                MessageBox.Show("The entered city is incorrect, Please enter a valid city.", "Invalid input", MessageBoxButtons.OK, (MessageBoxIcon)MessageBoxImage.Warning);
            }
           
            
        }

        private void txt_cityName_TextChanged(object sender, EventArgs e)
        {
            if (txt_cityName.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the data ?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
           
            {
                deleteData();
                showDbData();
            }
            



            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                weatherForecast wf = new weatherForecast();
                wf.country = country;  //country
                wf.ccity = lbl_cityName.Text;  //city
                wf.date = currentdate;
                wf.cond = lbl_cond.Text;
                wf.minTemp = lbl_0minTemp.Text;
                wf.maxTemp = lbl_0maxTemp.Text;
                wf.wind = lbl_0wind.Text;

                SqliteDataAccess.SaveData(wf);
                showDbData();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            
        }
    }
}
