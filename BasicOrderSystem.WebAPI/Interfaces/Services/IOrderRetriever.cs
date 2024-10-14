using BasicOrderSystem.Models;

namespace BasicOrderSystem.WebAPI.Interfaces.Services
{
    public interface IOrderRetriever
    {
        Task<IList<Customer>> GetCustomersAsync(CancellationToken cancellationToken);
        Task<IList<Order>> GetOrdersAsync(CancellationToken cancellationToken);
        //Look at adding options for status, placed/delivered date, customer and order ID
    }
}