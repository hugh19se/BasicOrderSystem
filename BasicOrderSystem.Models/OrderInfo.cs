using System.Text.Json.Serialization;

namespace BasicOrderSystem.Models
{
    public class OrderInfo
    {
        [JsonPropertyName("order")]
        public Order Order { get; set; }
        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }
    }
}