using BasicOrderSystem.Models;
using BasicOrderSystem.WebAPI.Interfaces.Repositories;
using BasicOrderSystem.WebAPI.Interfaces.Services;
using BasicOrderSystem.WebAPI.Options;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace BasicOrderSystem.WebAPI.Repositories
{
    public class OrderDBRepository : IOrderDBRepository
    {
        private readonly ILogger<OrderDBRepository> _logger;
        private readonly IConnectionStringBuilder _connectionStringBuilder;
        private readonly OrderDBOptions _orderDBOptions;

        public OrderDBRepository(ILogger<OrderDBRepository> logger
                               , IConnectionStringBuilder connectionStringBuilder
                               , IOptions<OrderDBOptions> orderDBOptions)
        {
            _logger = logger;
            _connectionStringBuilder = connectionStringBuilder;
            _orderDBOptions = orderDBOptions.Value;
        }

        public async Task<IList<Customer>> GetCustomersAsync(CancellationToken cancellationToken)
        {
            List<Customer> customers = new();
            try
            {
                string connectionString = _connectionStringBuilder.GetConnectionString(_orderDBOptions.ConnectionString);
                using (SqlConnection sqlConnection = new(connectionString))
                using (SqlCommand sqlCmd = sqlConnection.CreateCommand())
                {
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.CommandText = _orderDBOptions.GetCustomersStoredProcedure;

                    await sqlConnection.OpenAsync(cancellationToken);
                    SqlDataReader dataReader = await sqlCmd.ExecuteReaderAsync(cancellationToken);
                    while (await dataReader.ReadAsync(cancellationToken))
                    {
                        customers.Add(new Customer
                        {
                            CustomerID = Convert.ToInt32(dataReader["CustomerID"]),
                            Email = Convert.ToString(dataReader["Email"]),
                            Forenames = Convert.ToString(dataReader["Forenames"]),
                            Surname = Convert.ToString(dataReader["Surname"]),
                            Line1 = Convert.ToString(dataReader["Line1"]),
                            Line2 = Convert.ToString(dataReader["Line2"]),
                            City = Convert.ToString(dataReader["City"]),
                            Postcode = Convert.ToString(dataReader["Postcode"]),
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION IN " + nameof(GetCustomersAsync));
                throw;
            }
            return customers;
        }
        public async Task<IList<Order>> GetOrdersAsync(DateTime fromDate, DateTime toDate, OrderStatus orderStatus, CancellationToken cancellationToken)
        {
            List<Order> orders = new();
            try
            {
                string connectionString = _connectionStringBuilder.GetConnectionString(_orderDBOptions.ConnectionString);
                using (SqlConnection sqlConnection = new(connectionString))
                using (SqlCommand sqlCmd = sqlConnection.CreateCommand())
                {
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.CommandText = _orderDBOptions.GetOrdersStoredProcedure;

                    sqlCmd.Parameters.Add(new SqlParameter("@FromDate", fromDate));
                    sqlCmd.Parameters.Add(new SqlParameter("@ToDate", toDate));
                    sqlCmd.Parameters.Add(new SqlParameter("@OrderStatus", orderStatus));

                    await sqlConnection.OpenAsync(cancellationToken);
                    SqlDataReader dataReader = await sqlCmd.ExecuteReaderAsync(cancellationToken);
                    while (await dataReader.ReadAsync(cancellationToken))
                    {
                        Order orderToAdd = new Order
                        {
                            OrderID = Convert.ToInt32(dataReader["OrderID"]),
                            CustomerID = Convert.ToInt32(dataReader["CustomerID"]),
                            Status = (OrderStatus)Convert.ToInt32(dataReader["Status"]),
                            Total = float.Parse(Convert.ToString(dataReader["Total"])),
                            OrderPlaced = DateTime.Parse(Convert.ToString(dataReader["OrderPlaced"]))
                        };

                        //OrderDelivered field can be null, check before adding to orderToAdd
                        string orderDeliveredString = Convert.ToString(dataReader["OrderDelivered"]);
                        if (!string.IsNullOrEmpty(orderDeliveredString))
                        {
                            orderToAdd.OrderDelivered = DateTime.Parse(orderDeliveredString);
                        }

                        orders.Add(orderToAdd);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION IN " + nameof(GetCustomersAsync));
                throw;
            }
            return orders;
        }
        public async Task<OrderInfo> GetOrderInfoAsync(int orderID, CancellationToken cancellationToken)
        {
            OrderInfo orderInfo = new();
            try
            {
                string connectionString = _connectionStringBuilder.GetConnectionString(_orderDBOptions.ConnectionString);
                using (SqlConnection sqlConnection = new(connectionString))
                using (SqlCommand sqlCmd = sqlConnection.CreateCommand())
                {
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.CommandText = _orderDBOptions.GetOrderInfoStoredProcedure;

                    sqlCmd.Parameters.Add(new SqlParameter("@OrderID", orderID));

                    await sqlConnection.OpenAsync(cancellationToken);
                    SqlDataReader dataReader = await sqlCmd.ExecuteReaderAsync(cancellationToken);
                    while (await dataReader.ReadAsync(cancellationToken))
                    {
                        //Get Order info
                        Order order = new Order
                        {
                            OrderID = Convert.ToInt32(dataReader["OrderID"]),
                            CustomerID = Convert.ToInt32(dataReader["CustomerID"]),
                            Status = (OrderStatus)Convert.ToInt32(dataReader["Status"]),
                            Total = float.Parse(Convert.ToString(dataReader["Total"])),
                            OrderPlaced = DateTime.Parse(Convert.ToString(dataReader["OrderPlaced"]))
                        };

                        //OrderDelivered field can be null, check before adding to orderToAdd
                        string orderDeliveredString = Convert.ToString(dataReader["OrderDelivered"]);
                        if (!string.IsNullOrEmpty(orderDeliveredString))
                        {

                            order.OrderDelivered = DateTime.Parse(orderDeliveredString);
                        }

                        //Get Customer info
                        var customer = new Customer
                        {
                            Email = Convert.ToString(dataReader["Email"]),
                            Forenames = Convert.ToString(dataReader["Forenames"]),
                            Surname = Convert.ToString(dataReader["Surname"]),
                            Line1 = Convert.ToString(dataReader["Line1"]),
                            Line2 = Convert.ToString(dataReader["Line2"]),
                            City = Convert.ToString(dataReader["City"]),
                            Postcode = Convert.ToString(dataReader["Postcode"]),
                        };

                        orderInfo = new OrderInfo()
                        {
                            Order = order,
                            Customer = customer
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION IN " + nameof(GetCustomersAsync));
                throw;
            }
            return orderInfo;
        }
        public async Task UpdateOrderInfoAsync(int orderID, OrderStatus status, DateTime? orderDelivered, CancellationToken cancellationToken)
        {
            try
            {
                string connectionString = _connectionStringBuilder.GetConnectionString(_orderDBOptions.ConnectionString);
                using (SqlConnection sqlConnection = new(connectionString))
                using (SqlCommand sqlCmd = sqlConnection.CreateCommand())
                {
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.CommandText = _orderDBOptions.UpdateOrderInfoStoredProcedure;

                    sqlCmd.Parameters.Add(new SqlParameter("@OrderID", orderID));
                    sqlCmd.Parameters.Add(new SqlParameter("@Status", status));
                    sqlCmd.Parameters.Add(new SqlParameter("@OrderDelivered", orderDelivered));

                    await sqlConnection.OpenAsync(cancellationToken);
                    await sqlCmd.ExecuteNonQueryAsync(cancellationToken);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION IN " + nameof(UpdateOrderInfoAsync));
                throw;
            }
        }
        public async Task CreateOrderAsync(float total, int customerID, CancellationToken cancellationToken)
        {
            try
            {
                string connectionString = _connectionStringBuilder.GetConnectionString(_orderDBOptions.ConnectionString);
                using (SqlConnection sqlConnection = new(connectionString))
                using (SqlCommand sqlCmd = sqlConnection.CreateCommand())
                {
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.CommandText = _orderDBOptions.CreateOrderStoredProcedure;

                    sqlCmd.Parameters.Add(new SqlParameter("@Total", total));
                    sqlCmd.Parameters.Add(new SqlParameter("@CustomerID", customerID));

                    await sqlConnection.OpenAsync(cancellationToken);
                    await sqlCmd.ExecuteNonQueryAsync(cancellationToken);
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
                string connectionString = _connectionStringBuilder.GetConnectionString(_orderDBOptions.ConnectionString);
                using (SqlConnection sqlConnection = new(connectionString))
                using (SqlCommand sqlCmd = sqlConnection.CreateCommand())
                {
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.CommandText = _orderDBOptions.DeleteOrderStoredProcedure;

                    sqlCmd.Parameters.Add(new SqlParameter("@OrderID", orderID));

                    await sqlConnection.OpenAsync(cancellationToken);
                    await sqlCmd.ExecuteNonQueryAsync(cancellationToken);
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