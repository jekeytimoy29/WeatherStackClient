using System.Collections.Generic;

namespace WeatherStackClient.Models
{
    public class Current
    {
        public string Observation_Time { get; set; }
        public double Temperature { get; set; }
        public int Weather_Code { get; set; }
        public string[] Weather_Icons { get; set; }
        public string[] Weather_Descriptions { get; set; }
        public double Wind_Speed { get; set; }
        public double Wind_Degree { get; set; }
        public string Wind_Dir  { get; set; }
        public double Pressure { get; set; }
        public double Precip { get; set; }
        public double Humidity { get; set; }
        public double CloudCover { get; set; }
        public double FeelsLike { get; set; }
        public double Uv_Index { get; set; }
        public double Visibility { get; set; }
        public string Is_Day { get; set; }
    }
}