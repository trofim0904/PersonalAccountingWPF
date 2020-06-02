using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Services
{
    public class WeatherProcessor
    {
        
        private float kelvinDifference = 273.15f;
        private int numbersAfterDot = 2;
        public async Task<WeatherModel> LoadWeather()
        {
            
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Kiev&appid=5e3b8aca13cbb2b2589fbb6b4e3a1777";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    WeatherModel weather = await response.Content.ReadAsAsync<WeatherModel>();
                    weather.Main.Feels_like -= kelvinDifference;
                    weather.Main.Temp_max -= kelvinDifference;
                    weather.Main.Temp_min -= kelvinDifference;
                    Math.Round(weather.Main.Feels_like, numbersAfterDot);
                    Math.Round(weather.Main.Temp_max, numbersAfterDot);
                    Math.Round(weather.Main.Temp_min, numbersAfterDot);
                    return weather;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
