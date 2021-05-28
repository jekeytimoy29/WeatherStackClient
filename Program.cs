using System;

namespace WeatherStackClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!! Welcome to the WeatherStack Client Application !!!");

            while(true)
            {
                Console.WriteLine("\nPress Ctrl+C to Exit.");
                Console.WriteLine("Please Enter Location City/Zipcode: ");
                string input = Console.ReadLine();
                ProcessWeather weather = new ProcessWeather(input);
                weather.DisplayResult();
                weather = null;
            }
        }
    }
}
