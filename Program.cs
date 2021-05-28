using System;

namespace WeatherStackClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Location City/Zipcode: ");
            string input = Console.ReadLine();
            ProcessWeather weather = new ProcessWeather(input);
            weather.DisplayResult();
        }
    }
}
