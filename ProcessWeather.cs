using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherStackClient.Models;
using WeatherStackClient.Services;

namespace WeatherStackClient
{
    public class ProcessWeather
    {
        private readonly string _location;

        public ProcessWeather(string location)
        {
            _location = location;
        }

        public void DisplayResult()
        {
            WeatherMessage message = GetCurrentWeather();

            if(message != null)
            {
                if(message.Current != null)
                {
                    string Yes = "Yes";
                    string No = "No";
                    bool isRaining = message.Current.Precip > 0;
                    bool isHighUVIndex = message.Current.Uv_Index > 3;
                    bool isStrongWind = message.Current.Wind_Speed > 15;
            
                    Console.WriteLine("{0}, {1} Current Weather", message.Location.Region, message.Location.Country);
                    Console.WriteLine("Should I go outside? {0}", !isRaining ? Yes : No);
                    Console.WriteLine("Should I wear sunscreen? {0}", isHighUVIndex ? Yes : No);
                    Console.WriteLine("Can I fly my kite? {0}", !isRaining && isStrongWind ? Yes : No);
                }
                else
                {
                    Console.WriteLine("Error: " + message.Error.Info);
                }
            }

            message = null;
        }

        public WeatherMessage GetCurrentWeather()
        {
            string query = "&query=" + _location;
            return WeatherService.GetTaskAsync("current", query).Result;
        }
    }
}