using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherStackClient.Models;

namespace WeatherStackClient.Services
{
    public class WeatherService
    { 
        private static readonly HttpClient _client;
        private const string _url = "http://api.weatherstack.com";
        private const string _accessKey = "bb05d29904cfa9ecca5e6f3efabaa289";

        static WeatherService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(_url);
        }

        public static async Task<WeatherMessage> GetWeatherAsync(string request, string queryCode)
        {
            try
            {
                return await _client.GetFromJsonAsync<WeatherMessage>("current?access_key=bb05d29904cfa9ecca5e6f3efabaa289&query=99501");
            }
            catch(HttpRequestException e)
            {
                Console.WriteLine("Exception Caught!");	
                Console.WriteLine("Message :{0} ",e.Message);
            }
            catch(JsonException)
            {
                Console.WriteLine("Invalid JSON.");
            }

            return null;
        }
    }
}