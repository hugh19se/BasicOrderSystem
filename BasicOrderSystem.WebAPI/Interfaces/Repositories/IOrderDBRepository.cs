using BasicOrderSystem.Models;

namespace BasicOrderSystem.WebAPI.Interfaces.Repositories
{
    public interface IOrderDBRepository
    {
        Task<IList<Customer>> GetCustomersAsync(CancellationToken cancellationToken);
        Task<IList<Order>> GetOrdersAsync(DateTime fromDate, DateTime toDate, OrderStatus orderStatus, CancellationToken cancellationToken);
        Task<OrderInfo> GetOrderInfoAsync(int orderID, CancellationToken cancellationToken);
    }
}