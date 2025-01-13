using BasicOrderSystem.Models;
using BasicOrderSystem.WebAPI.Interfaces.DataAccess;
using BasicOrderSystem.WebAPI.Interfaces.Repositories;

namespace BasicOrderSystem.WebAPI.DataAccess
{
    public class OrderDBRepositoryDataAccess : IOrderDBRepositoryDataAccess
    {
        private readonly IOrderDBRepository _orderDBRepository;

        public OrderDBRepositoryDataAccess(IOrderDBRepository orderDBRepository)
        {
            _orderDBRepository = orderDBRepository;
        }
        public async Task<IList<Customer>> GetCustomersAsync(CancellationToken cancellationToken)
        {
            return await _orderDBRepository.GetCustomersAsync(cancellationToken);
        }
        public async Task<IList<Order>> GetOrdersAsync(DateTime fromDate, DateTime toDate, OrderStatus orderStatus, CancellationToken cancellationToken)
        {
            return await _orderDBRepository.GetOrdersAsync(fromDate, toDate, orderStatus, cancellationToken);
        }
        public async Task<OrderInfo> GetOrderInfoAsync(int orderID, CancellationToken cancellationToken)
        {
            return await _orderDBRepository.GetOrderInfoAsync(orderID, cancellationToken);
        }
        public async Task UpdateOrderInfoAsync(int orderID, OrderStatus status, DateTime? orderDelivered, CancellationToken cancellationToken)
        {
            await _orderDBRepository.UpdateOrderInfoAsync(orderID, status, orderDelivered, cancellationToken);
        }
        public async Task CreateOrderAsync(float total, int customerID, CancellationToken cancellationToken)
        {
            await _orderDBRepository.CreateOrderAsync(total, customerID, cancellationToken);
        }
        public async Task DeleteOrderAsync(int orderID, CancellationToken cancellationToken)
        {
            await _orderDBRepository.DeleteOrderAsync(orderID, cancellationToken);
        }
    }
}
