namespace WeatherStackClient.Models
{
    public class BaseMessage
    {
        public bool Success { get; set; }
        public ErrorMessage Error { get; set; }
    }
}