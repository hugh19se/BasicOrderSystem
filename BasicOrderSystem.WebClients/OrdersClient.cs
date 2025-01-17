﻿using BasicOrderSystem.Models;
using BasicOrderSystem.WebContracts;

namespace BasicOrderSystem.WebClients
{
    public class OrdersClient : ClientBase
    {
        private readonly string ControllerRoute = "/api/Orders/";

        public OrdersClient(string baseAddress, int timeout = 60)
            : base(baseAddress, timeout) { }

        public async Task<GetCustomersResponse> GetCustomersAsync()
        {
            return await GetResponse<GetCustomersResponse>(ControllerRoute + "GetCustomers");
        }
        public async Task<GetOrdersResponse> GetOrdersAsync(DateTime fromDate, DateTime toDate, OrderStatus orderStatus)
        {
            return await GetResponse<GetOrdersResponse>(ControllerRoute + $"GetOrders?fromDate={fromDate}&toDate={toDate}&orderStatus={(int)orderStatus}");
        }
        public async Task<GetOrderInfoResponse> GetOrderInfoAsync(int orderID)
        {
            return await GetResponse<GetOrderInfoResponse>(ControllerRoute + $"GetOrderInfo?orderID={orderID}");
        }
        public async Task UpdateOrderInfoAsync(int orderID, OrderStatus orderStatus, DateTime? orderDelivered)
        {
            UpdateOrderInfoRequest updateOrderInfoRequestBody = new()
            {
                OrderID = orderID,
                Status = orderStatus,
                OrderDelivered = orderDelivered
            };

            await PostRequest<UpdateOrderInfoRequest>(ControllerRoute + "UpdateOrderInfo", updateOrderInfoRequestBody);
        }
        public async Task CreateOrderAsync(float total, int customerID)
        {
            CreateOrderRequest createOrderRequestBody = new()
            {
                Total = total,
                CustomerID = customerID
            };

            await PutRequest<CreateOrderRequest>(ControllerRoute + "CreateOrder", createOrderRequestBody);
        }
        public async Task<DeleteOrderResponse> DeleteOrderAsync(int orderID)
        {
            return await DeleteRequest<DeleteOrderResponse>(ControllerRoute + $"DeleteOrder?orderID={orderID}");
        }
    }
}
