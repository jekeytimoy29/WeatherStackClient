namespace WeatherStackClient.Models
{
    public class BaseMessage
    {
        public bool Success { get; set; }
        public ErrorResponse Error { get; set; }
    }
}