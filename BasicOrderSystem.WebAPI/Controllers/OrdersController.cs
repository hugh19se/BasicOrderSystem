﻿using BasicOrderSystem.Models;
using BasicOrderSystem.WebAPI.Interfaces.Services;
using BasicOrderSystem.WebContracts;
using Microsoft.AspNetCore.Mvc;

namespace BasicOrderSystem.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly IOrderRetriever _orderRetriever;
        public OrdersController(ILogger<OrdersController> logger
                              , IOrderRetriever orderRetriever)
        {
            _logger = logger;
            _orderRetriever = orderRetriever;
        }

        [HttpGet]
        public async Task<GetCustomersResponse> GetCustomersAsync(CancellationToken cancellationToken)
        {
            GetCustomersResponse response = new();
            try
            {
                response.Customers = await _orderRetriever.GetCustomersAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION In: " + nameof(GetCustomersAsync));
                response.HasError = true;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        [HttpGet]
        public async Task<GetOrdersResponse> GetOrdersAsync(DateTime fromDate, DateTime toDate, CancellationToken cancellationToken)
        {
            GetOrdersResponse response = new();
            try
            {
                response.Orders = await _orderRetriever.GetOrdersAsync(fromDate, toDate, cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION In: " + nameof(GetOrdersAsync));
                response.HasError = true;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
        [HttpGet]
        public async Task<GetOrderInfoResponse> GetOrderInfoAsync(int orderID, CancellationToken cancellationToken)
        {
            GetOrderInfoResponse response = new();
            try
            {
                KeyValuePair<Order, Customer> orderInfo = await _orderRetriever.GetOrderInfoAsync(orderID, cancellationToken);
                response.Order = orderInfo.Key;
                response.Customer = orderInfo.Value;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION In: " + nameof(GetOrderInfoAsync));
                response.HasError = true;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
    }
}