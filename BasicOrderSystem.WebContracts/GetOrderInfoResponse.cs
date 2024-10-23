using BasicOrderSystem.Models;
using BasicOrderSystem.WebContracts.Bases;
using System.Text.Json.Serialization;

namespace BasicOrderSystem.WebContracts
{
    public class GetOrderInfoResponse : ResponseBase
    {
        [JsonPropertyName("order")]
        public Order Order { get; set; }
        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }
    }
}