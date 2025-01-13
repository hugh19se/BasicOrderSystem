using BasicOrderSystem.Models;
using BasicOrderSystem.WebAPI.Interfaces.Services;
using BasicOrderSystem.WebAPI.Options;
using Microsoft.Extensions.Options;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

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
                IList<Order>? filteredOrders = orders.Where(x => x.OrderPlaced >= fromDate && x.OrderPlaced <= toDate && (x.Status == orderStatus || orderStatus == OrderStatus.All)).ToList();

                return filteredOrders;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION In " + nameof(GetOrdersAsync));
                throw;
            }
        }
        public async Task<OrderInfo> GetOrderInfoAsync(int orderID, CancellationToken cancellationToken)
        {
            try
            {
                //Get orders
                string ordersText = await File.ReadAllTextAsync(_orderRetrieverOptions.OrdersPath, cancellationToken);
                byte[] ordersBytes = Encoding.UTF8.GetBytes(ordersText);
                MemoryStream ordersMemoryStream = new(ordersBytes);
                IList<Order>? orders = await JsonSerializer.DeserializeAsync<IList<Order>>(ordersMemoryStream, JsonSerializerOptions.Default, cancellationToken);

                //Get customers
                string customersText = await File.ReadAllTextAsync(_orderRetrieverOptions.CustomersPath, cancellationToken);
                byte[] customersBytes = Encoding.UTF8.GetBytes(customersText);
                MemoryStream customersMemoryStream = new(customersBytes);
                IList<Customer>? customers = await JsonSerializer.DeserializeAsync<IList<Customer>>(customersMemoryStream, JsonSerializerOptions.Default, cancellationToken);

                Order order = orders.Where(x => x.OrderID == orderID).FirstOrDefault();
                Customer orderCustomer = customers.Where(x => x.CustomerID == order.CustomerID).FirstOrDefault();

                return new OrderInfo()
                {
                    Order = order,
                    Customer = orderCustomer
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION In " + nameof(GetOrdersAsync));
                throw;
            }
        }
        public async Task UpdateOrderInfoAsync(int orderID, OrderStatus status, DateTime? orderDelivered, CancellationToken cancellationToken)
        {
            try
            {
                //Get orders
                string ordersText = await File.ReadAllTextAsync(_orderRetrieverOptions.OrdersPath, cancellationToken);
                byte[] ordersBytes = Encoding.UTF8.GetBytes(ordersText);
                MemoryStream ordersMemoryStream = new(ordersBytes);
                IList<Order>? orders = await JsonSerializer.DeserializeAsync<IList<Order>>(ordersMemoryStream, JsonSerializerOptions.Default, cancellationToken);

                //Get order we want to modify from list of orders
                Order order = orders.Where(x => x.OrderID == orderID).FirstOrDefault();

                //Remove the existing order
                orders.Remove(order);

                //Modify order data
                order.Status = status;
                order.OrderDelivered = orderDelivered;

                //Add modified order back to orders list
                orders.Add(order);

                //Reorder orders by Order ID ascending
                orders = orders.OrderBy(x => x.OrderID).ToList();

                //Write updated orders object to JSON file
                JsonTypeInfo<IList<Order>> ordersJsonTypeInfo = JsonTypeInfo.CreateJsonTypeInfo<IList<Order>>(JsonSerializerOptions.Default);
                await using (FileStream writeStream = File.Create(_orderRetrieverOptions.OrdersPath))
                {
                    await JsonSerializer.SerializeAsync(writeStream, orders, ordersJsonTypeInfo, cancellationToken);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION In " + nameof(UpdateOrderInfoAsync));
                throw;
            }
        }
        public async Task CreateOrderAsync(float total, int customerID, CancellationToken cancellationToken)
        {
            try
            {
                //Get orders
                string ordersText = await File.ReadAllTextAsync(_orderRetrieverOptions.OrdersPath, cancellationToken);
                byte[] ordersBytes = Encoding.UTF8.GetBytes(ordersText);
                MemoryStream ordersMemoryStream = new(ordersBytes);
                IList<Order>? orders = await JsonSerializer.DeserializeAsync<IList<Order>>(ordersMemoryStream, JsonSerializerOptions.Default, cancellationToken);

                //Create new order object
                Order orderToAdd = new()
                {
                    OrderID = orders.Count + 1,
                    CustomerID = customerID,
                    Status = OrderStatus.Created,
                    Total = total,
                    OrderPlaced = DateTime.Now
                };

                //Add new order to orders list
                orders.Add(orderToAdd);

                //Reorder orders by Order ID ascending
                orders = orders.OrderBy(x => x.OrderID).ToList();

                //Write updated orders object to JSON file
                JsonTypeInfo<IList<Order>> ordersJsonTypeInfo = JsonTypeInfo.CreateJsonTypeInfo<IList<Order>>(JsonSerializerOptions.Default);
                await using (FileStream writeStream = File.Create(_orderRetrieverOptions.OrdersPath))
                {
                    await JsonSerializer.SerializeAsync(writeStream, orders, ordersJsonTypeInfo, cancellationToken);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION In " + nameof(CreateOrderAsync));
                throw;
            }
        }
        public async Task DeleteOrderAsync(int orderID, CancellationToken cancellationToken)
        {
            try
            {
                //Get orders
                string ordersText = await File.ReadAllTextAsync(_orderRetrieverOptions.OrdersPath, cancellationToken);
                byte[] ordersBytes = Encoding.UTF8.GetBytes(ordersText);
                MemoryStream ordersMemoryStream = new(ordersBytes);
                IList<Order>? orders = await JsonSerializer.DeserializeAsync<IList<Order>>(ordersMemoryStream, JsonSerializerOptions.Default, cancellationToken);

                //Get order to remove
                Order orderToRemove = orders.Where(x => x.OrderID == orderID).FirstOrDefault();

                //Remove order from list
                orders.Remove(orderToRemove);

                //Reorder orders by Order ID ascending
                orders = orders.OrderBy(x => x.OrderID).ToList();

                //Write updated orders object to JSON file
                JsonTypeInfo<IList<Order>> ordersJsonTypeInfo = JsonTypeInfo.CreateJsonTypeInfo<IList<Order>>(JsonSerializerOptions.Default);
                await using (FileStream writeStream = File.Create(_orderRetrieverOptions.OrdersPath))
                {
                    await JsonSerializer.SerializeAsync(writeStream, orders, ordersJsonTypeInfo, cancellationToken);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION In " + nameof(DeleteOrderAsync));
                throw;
            }
        }
    }
}