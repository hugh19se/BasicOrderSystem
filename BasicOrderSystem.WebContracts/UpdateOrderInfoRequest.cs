using BasicOrderSystem.Models;
using BasicOrderSystem.WebContracts.Bases;
using System.Text.Json.Serialization;

namespace BasicOrderSystem.WebContracts
{
    public class UpdateOrderInfoRequest : RequestBase
    {
        [JsonPropertyName("order_id")]
        public int OrderID { get; set; }
        [JsonPropertyName("status")]
        public OrderStatus Status { get; set; }
        [JsonPropertyName("order_delivered")]
        public DateTime? OrderDelivered { get; set; }
    }
}