using BasicOrderSystem.Models;
using BasicOrderSystem.WebAPI.Interfaces.Services;
using BasicOrderSystem.WebAPI.Options;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace BasicOrderSystem.WebAPI.Services
{
    public class JSONOrderRetriever : IOrderRetriever
    {
		private readonly ILogger<JSONOrderRetriever> _logger;
        private readonly JSONOrderRetrieverOptions _orderRetrieverOptions;
        public JSONOrderRetriever(ILogger<JSONOrderRetriever> logger
                                    , IOptionsSnapshot<JSONOrderRetrieverOptions> orderRetrieverOptions)
        {
            _logger = logger;
            _orderRetrieverOptions = orderRetrieverOptions.Value;
        }

        public async Task<IList<Customer>> GetCustomersAsync(CancellationToken cancellationToken)
        {
			try
			{
                string customersText = await File.ReadAllTextAsync(_orderRetrieverOptions.CustomersPath);
                var customers = JsonSerializer.Deserialize<IList<Customer>>(customersText);

                return customers;
			}
			catch (Exception ex)
			{
                _logger.LogError(ex, "EXCEPTION In " + nameof(GetCustomersAsync));
				throw;
			}
        }
    }
}
