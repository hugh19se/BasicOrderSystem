using BasicOrderSystem.Models;
using BasicOrderSystem.WebContracts.Bases;
using System.Text.Json.Serialization;

namespace BasicOrderSystem.WebContracts
{
    public class GetOrdersResponse : ResponseBase
    {
        [JsonPropertyName("orders")]
        public IList<Order> Orders { get; set; }
    }
}
