    namespace BasicOrderSystem.WebAPI.Options
{
    public class JSONOrderRetrieverOptions
    {
        public const string ConfigBinding = "JSONOrderRetriever";

        public string CustomersPath { get; set; } = string.Empty;
        public string OrdersPath { get; set; } = string.Empty;
    }
}
