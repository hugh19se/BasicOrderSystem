using BasicOrderSystem.Models;
using BasicOrderSystem.WebAPI.Interfaces.Services;
using BasicOrderSystem.WebAPI.Options;
using Microsoft.Extensions.Options;
using System.Text;
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
                byte[] customersBytes = Encoding.UTF8.GetBytes(customersText);
                MemoryStream customersMemoryStream = new(customersBytes);
                IList<Customer>? customers = await JsonSerializer.DeserializeAsync<IList<Customer>>(customersMemoryStream, JsonSerializerOptions.Default, cancellationToken);
                return customers;
			}
			catch (Exception ex)
			{
                _logger.LogError(ex, "EXCEPTION In " + nameof(GetCustomersAsync));
				throw;
            }
        }
        public async Task<IList<Order>> GetOrdersAsync(DateTime fromDate, DateTime toDate, CancellationToken cancellationToken)
        {
            try
            {
                string ordersText = await File.ReadAllTextAsync(_orderRetrieverOptions.OrdersPath, cancellationToken);
                byte[] ordersBytes = Encoding.UTF8.GetBytes(ordersText);
                MemoryStream ordersMemoryStream = new(ordersBytes);
                IList<Order>? orders = await JsonSerializer.DeserializeAsync<IList<Order>>(ordersMemoryStream, JsonSerializerOptions.Default, cancellationToken);

                IList<Order>? filteredOrders = orders.Where(x => x.OrderPlaced >= fromDate && x.OrderPlaced <= toDate).ToList();

                return filteredOrders;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION In " + nameof(GetOrdersAsync));
                throw;
            }
        }
    }
}
