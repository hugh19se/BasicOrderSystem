namespace BasicOrderSystem.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string? Email { get; set; }
        public string? Forenames { get; set; }
        public string? Surname { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? City { get; set; }
        public string? Postcode { get; set; }
    }
}