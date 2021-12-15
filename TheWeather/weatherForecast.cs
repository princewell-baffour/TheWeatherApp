using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWeather
{
    public class weatherForecast
    {
        public string country { get; set; }
        public string cityN { get; set; }
        public string date { get; set; }
        public string cond { get; set; }
        public string minTemp { get; set; }
        public string maxTemp { get; set; }
        public string wind { get; set; }

        public city city { get; set; }
        public List<list> list { get; set; } //forecast list
    }

    public class temp
    {
        public double min { get; set; }
        public double max { get; set; }
    }
  
    public class weather
    {
        public string main { get; set; } //weather condition
        public string description { get; set; } //weather description
    }
    public class city
    {
        public string name { get; set; }
    }
    public class list
    {
        public double dt { get; set; } //days in millisecond
        public double pressure { get; set; } //pressure in hpa
        public double humidity { get; set; } //humidity in %
        public double speed { get; set; } //wind speed in millisecond
        public temp temp { get; set; } //min and max temp
        public List<weather> weather { get; set; } //weather list
    }
}
