using BasicOrderSystem.WebContracts.Bases;
using System.Text.Json.Serialization;

namespace BasicOrderSystem.WebContracts
{
    public class CreateOrderRequest : RequestBase
    {
        [JsonPropertyName("total")]
        public float Total { get; set; }
        [JsonPropertyName("customer_id")]
        public int CustomerID { get; set; }
    }
}