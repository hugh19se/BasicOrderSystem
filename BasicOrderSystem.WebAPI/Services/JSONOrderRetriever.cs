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
                //get customers
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
        public async Task<IList<Order>> GetOrdersAsync(DateTime fromDate, DateTime toDate, OrderStatus orderStatus, CancellationToken cancellationToken)
        {
            try
            {
                //Get orders
                string ordersText = await File.ReadAllTextAsync(_orderRetrieverOptions.OrdersPath, cancellationToken);
                byte[] ordersBytes = Encoding.UTF8.GetBytes(ordersText);
                MemoryStream ordersMemoryStream = new(ordersBytes);
                IList<Order>? orders = await JsonSerializer.DeserializeAsync<IList<Order>>(ordersMemoryStream, JsonSerializerOptions.Default, cancellationToken);

                //Filter orders based on date range and order status
                IList<Order>? filteredOrders = orders.Where(x => x.OrderPlaced >= fromDate && x.OrderPlaced <= toDate && x.Status == orderStatus).ToList();

                return filteredOrders;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION In " + nameof(GetOrdersAsync));
                throw;
            }
        }
        public async Task<KeyValuePair<Order, Customer>> GetOrderInfoAsync(int orderID, CancellationToken cancellationToken)
        {
            try
            {
                IList<Order> orders = await GetOrdersAsync(DateTime.MinValue, DateTime.MaxValue, cancellationToken);
                IList<Customer> customers = await GetCustomersAsync(cancellationToken);

                Order order = orders.Where(x => x.OrderID == orderID).FirstOrDefault();
                Customer orderCustomer = customers.Where(x => x.CustomerID == order.CustomerID).FirstOrDefault();

                return new KeyValuePair<Order, Customer>(order, orderCustomer);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION In " + nameof(GetOrdersAsync));
                throw;
            }
        }
    }
}
