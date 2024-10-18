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
        public async Task<IList<Order>> GetOrdersAsync(DateTime fromDate, DateTime toDate, CancellationToken cancellationToken)
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

                    await sqlConnection.OpenAsync(cancellationToken);
                    SqlDataReader dataReader = await sqlCmd.ExecuteReaderAsync(cancellationToken);
                    while (await dataReader.ReadAsync(cancellationToken))
                    {
                        Order orderToAdd = new Order
                        {
                            OrderID = Convert.ToInt32(dataReader["OrderID"]),
                            CustomerID = Convert.ToInt32(dataReader["CustomerID"]),
                            Status = Convert.ToInt32(dataReader["Status"]),
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
    }
}
