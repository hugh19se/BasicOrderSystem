using BasicOrderSystem.Models;
using BasicOrderSystem.WebContracts.Bases;
using System.Text.Json.Serialization;

namespace BasicOrderSystem.WebContracts
{
    public class GetOrderInfoResponse : ResponseBase
    {
        [JsonPropertyName("order-info")]
        public OrderInfo OrderInfo { get; set; }
    }
}