﻿using BasicOrderSystem.Models;

namespace BasicOrderSystem.WebAPI.Interfaces.Services
{
    public interface IOrderRetriever
    {
        Task<IList<Customer>> GetCustomersAsync(CancellationToken cancellationToken);
        Task<IList<Order>> GetOrdersAsync(DateTime fromDate, DateTime toDate, OrderStatus orderStatus, CancellationToken cancellationToken);
        Task<OrderInfo> GetOrderInfoAsync(int orderID, CancellationToken cancellationToken);
        Task UpdateOrderInfoAsync(int orderID, OrderStatus status, DateTime? orderDelivered, CancellationToken cancellationToken);
        Task CreateOrderAsync(float total, int customerID, CancellationToken cancellationToken);
        Task DeleteOrderAsync(int orderID, CancellationToken cancellationToken);
    }
}