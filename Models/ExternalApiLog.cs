namespace ProductsAPI.Models
{
    public class ExternalApiLog
    {
        public int Id { get; set; }
        public string ApiName { get; set; }
        public string RequestUrl { get; set; }
        public string ResponseData { get; set; }
        public DateTime CalledAt { get; set; }
    }
}
