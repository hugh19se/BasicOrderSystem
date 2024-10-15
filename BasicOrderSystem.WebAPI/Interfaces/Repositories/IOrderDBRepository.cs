using BasicOrderSystem.Models;

namespace BasicOrderSystem.WebAPI.Interfaces.Repositories
{
    public interface IOrderDBRepository
    {
        Task<IList<Customer>> GetCustomersAsync(CancellationToken cancellationToken);
        Task<IList<Order>> GetOrdersAsync(CancellationToken cancellationToken);
    }
}