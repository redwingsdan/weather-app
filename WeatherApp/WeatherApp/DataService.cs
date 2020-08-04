using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class DataService
    {
        public static async Task<dynamic> getDataFromService(String query)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(query);

            dynamic data = null;
            if(response != null)
            {
                String json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);
            }

            return data;
        }
    }
}
