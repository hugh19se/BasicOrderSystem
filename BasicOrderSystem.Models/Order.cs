using System.Text.Json.Serialization;

namespace BasicOrderSystem.Models
{
    public class Order
    {
        [JsonPropertyName("order_id")]
        public int OrderID { get; set; }
        [JsonPropertyName("customer_id")]
        public int CustomerID { get; set; }
        [JsonPropertyName("status")]
        public int Status { get; set; }
        [JsonPropertyName("total")]
        public float Total { get; set; }
        [JsonPropertyName("order_placed")]
        public DateTime OrderPlaced { get; set; }
        [JsonPropertyName("order_delivered")]
        public DateTime? OrderDelivered { get; set; }
    }
}