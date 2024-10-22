using System.Text.Json.Serialization;

namespace BasicOrderSystem.Models
{
    public class Customer
    {
        [JsonPropertyName("customer_id")]
        public int CustomerID { get; set; }
        [JsonPropertyName("email")]
        public string? Email { get; set; }
        [JsonPropertyName("forenames")]
        public string? Forenames { get; set; }
        [JsonPropertyName("surname")]
        public string? Surname { get; set; }
        [JsonPropertyName("line_1")]
        public string? Line1 { get; set; }
        [JsonPropertyName("line_2")]
        public string? Line2 { get; set; }
        [JsonPropertyName("city")]
        public string? City { get; set; }
        [JsonPropertyName("postcode")]
        public string? Postcode { get; set; }
    }
}