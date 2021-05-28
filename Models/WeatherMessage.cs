namespace WeatherStackClient.Models
{
    public class WeatherMessage : BaseMessage
    {
        public Request Request { get; set; }
        public Location Location { get; set; }
        public Current Current { get; set; }
        
    }
}