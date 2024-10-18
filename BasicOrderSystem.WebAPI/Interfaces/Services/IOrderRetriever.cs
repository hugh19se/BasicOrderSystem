﻿using BasicOrderSystem.Models;

namespace BasicOrderSystem.WebAPI.Interfaces.Services
{
    public interface IOrderRetriever
    {
        Task<IList<Customer>> GetCustomersAsync(CancellationToken cancellationToken);
        Task<IList<Order>> GetOrdersAsync(DateTime fromDate, DateTime toDate, CancellationToken cancellationToken);
        //Look at adding options for status, customer and order ID
    }
}