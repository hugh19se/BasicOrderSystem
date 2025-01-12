using BasicOrderSystem.Models;

namespace BasicOrderSystem.WebAPI.Options
{
    public class OrderDBOptions
    {
        public const string ConfigBinding = "OrderDB";
        public ConnectionStringConfig ConnectionString { get; set; }
        public string GetCustomersStoredProcedure { get; set; }
        public string GetOrdersStoredProcedure { get; set; }
        public string GetOrderInfoStoredProcedure { get; set; }
        public string UpdateOrderInfoStoredProcedure { get; set; }
    }
}
