using BasicOrderSystem.Models;
using BasicOrderSystem.WebAPI.Interfaces.DataAccess;
using BasicOrderSystem.WebAPI.Interfaces.Services;

namespace BasicOrderSystem.WebAPI.Services
{
    public class SQLServerOrderRetriever : IOrderRetriever
    {
        private readonly ILogger<JSONOrderRetriever> _logger;
        private readonly IOrderDBRepositoryDataAccess _orderDBRepositoryDataAccess;
        public SQLServerOrderRetriever(ILogger<JSONOrderRetriever> logger,
                                       IOrderDBRepositoryDataAccess orderDBRepositoryDataAccess)
        {
            _logger = logger;
            _orderDBRepositoryDataAccess = orderDBRepositoryDataAccess;
        }

        public async Task<IList<Customer>> GetCustomersAsync(CancellationToken cancellationToken)
        {
            try
            {
                return await _orderDBRepositoryDataAccess.GetCustomersAsync(cancellationToken);
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
                return await _orderDBRepositoryDataAccess.GetOrdersAsync(fromDate, toDate, cancellationToken);
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
                return await _orderDBRepositoryDataAccess.GetOrderInfoAsync(orderID, cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION In " + nameof(GetOrdersAsync));
                throw;
            }
        }
    }
}
