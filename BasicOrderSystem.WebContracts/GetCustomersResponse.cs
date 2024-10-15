using BasicOrderSystem.Models;
using BasicOrderSystem.WebContracts.Bases;
using System.Text.Json.Serialization;

namespace BasicOrderSystem.WebContracts
{
    public class GetCustomersResponse : ResponseBase
    {
        [JsonPropertyName("customers")]
        public IList<Customer> Customers { get; set; }
    }
}
