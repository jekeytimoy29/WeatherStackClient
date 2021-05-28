using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherStackClient.Services;

namespace WeatherStackClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await ProcessWeather.DisplayResult();
        }
    }
}
