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
                string customersText = await File.ReadAllTextAsync(_orderRetrieverOptions.CustomersPath, cancellationToken);
                var customers = JsonSerializer.Deserialize<IList<Customer>>(customersText);//change to async

                return customers;
			}
			catch (Exception ex)
			{
                _logger.LogError(ex, "EXCEPTION In " + nameof(GetCustomersAsync));
				throw;
            }
        }
        public async Task<IList<Order>> GetOrdersAsync(CancellationToken cancellationToken)
        {
            try
            {
                string ordersText = await File.ReadAllTextAsync(_orderRetrieverOptions.OrdersPath, cancellationToken);
                IList<Order> orders = JsonSerializer.Deserialize<IList<Order>>(ordersText);//change to async

                return orders;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION In " + nameof(GetOrdersAsync));
                throw;
            }
        }
    }
}
