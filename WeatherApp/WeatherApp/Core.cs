using System;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Core
    {
        public static async Task<Weather> getWeather(String zipCode)
        {
            String key = "d74c398993402af3969df1e1e60103f1";
            String query = "http://api.openweathermap.org/data/2.5/weather?zip=" + zipCode + ",us&appid=" + key + "&units=imperial";

            dynamic results = await DataService.getDataFromService(query).ConfigureAwait(false);
            if(results["weather"] != null)
            {
                Weather weather = new Weather();
                weather.title = (String)results["name"];
                weather.temperature = (String)results["main"]["temp"] + " F";
                weather.wind = (String)results["wind"]["speed"] + " mph";
                weather.humidity = (String)results["main"]["humidity"] + " %";
                weather.visibility = (String)results["weather"][0]["main"];

                DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);
                weather.sunrise = sunrise.ToString() + " UTC";
                weather.sunset = sunset.ToString() + " UTC";
                return weather;
            }
            else
            {
                return null;
            }
        }
    }
}
