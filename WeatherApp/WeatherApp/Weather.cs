using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Weather
    {
        public String title { get; set; }
        public String temperature { get; set; }
        public String wind { get; set; }
        public String humidity { get; set; }
        public String visibility { get; set; }
        public String sunrise { get; set; }
        public String sunset { get; set; }

        public Weather()
        {
            this.title = " ";
            this.temperature = " ";
            this.wind = " ";
            this.humidity = " ";
            this.visibility = " ";
            this.sunrise = " ";
            this.sunset = " ";
        }
    }
}
