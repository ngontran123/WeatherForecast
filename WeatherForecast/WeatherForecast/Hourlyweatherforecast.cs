using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    class Hourlyweatherforecast
    {
        public class main
        {
            public long temp_max { get; set; }
            public long temp_min { get; set; }
        }
        public class city
        {
            public long timezone { get; set; }
        }
        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
        }
        public class list
        {
            public long dt { get; set; }
         
            public main main { get; set; }
            public List<weather> weather { get; set; }
        }

        public class hourlylist
        {
            public List<list> list { get; set;}
            public city city { get; set; }

        }
    }
}
