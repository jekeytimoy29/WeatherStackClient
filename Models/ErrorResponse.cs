namespace WeatherStackClient.Models
{
    public class ErrorResponse
    {
        public int Code { get; set; }
        public string Type { get; set; }
        public string Info { get; set; }
    }
}