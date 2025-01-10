using BasicOrderSystem.Models;
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
    }
}
