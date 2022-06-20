using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WeatherForecast
{
    class DailyWeatherInfor
    {
        public class temp
        {
            public long min { get; set; }
            public long max { get; set; }
        }
        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
        }
        public class list
        {
            public long dt { get; set; }
            public long timezone { get; set; }
            public int humidity { get; set; }
            public temp temp { get;set;}
            public List<weather> weather { get; set; }
        }
        public class Forecastlist
        {
            public List<list> list { get; set; }
        }
    }
}

