using System;

namespace WeatherStackClient.Models
{
    public class Location
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Lat { get; set; }
        public string  Lon { get; set; }
        public string Timezone_Id { get; set; }
        public string LocalTime { get; set; }
        public long LocalTime_Epoch { get; set; } 
        public string Utc_Offset { get; set; }
    }
}