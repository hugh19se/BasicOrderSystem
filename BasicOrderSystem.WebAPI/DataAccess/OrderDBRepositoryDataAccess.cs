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
        public async Task<IList<Order>> GetOrdersAsync(CancellationToken cancellationToken)
        {
            return await _orderDBRepository.GetOrdersAsync(cancellationToken);
        }
    }
}
