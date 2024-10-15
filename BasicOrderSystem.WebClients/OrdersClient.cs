using BasicOrderSystem.WebContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOrderSystem.WebClients
{
    public class OrdersClient : ClientBase
    {
        private readonly string ControllerRoute = "/api/Orders/";

        public OrdersClient(string baseAddress, int timeout = 60)
            : base(baseAddress, timeout){}

        public async Task<GetCustomersResponse> GetCustomersAsync()
        {
            return await GetResponse<GetCustomersResponse>(ControllerRoute + "GetCustomers");
        }

        public async Task<GetOrdersResponse> GetOrdersAsync()
        {
            return await GetResponse<GetOrdersResponse>(ControllerRoute + "GetOrders");
        }
    }
}
