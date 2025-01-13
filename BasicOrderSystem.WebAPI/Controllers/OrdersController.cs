using BasicOrderSystem.Models;
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
        public async Task<GetOrdersResponse> GetOrdersAsync(DateTime fromDate, DateTime toDate, OrderStatus orderStatus, CancellationToken cancellationToken)
        {
            GetOrdersResponse response = new();
            try
            {
                response.Orders = await _orderRetriever.GetOrdersAsync(fromDate, toDate, orderStatus, cancellationToken);
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
                response.OrderInfo = await _orderRetriever.GetOrderInfoAsync(orderID, cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION In: " + nameof(GetOrderInfoAsync));
                response.HasError = true;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
        [HttpPost]
        public async Task<UpdateOrderInfoResponse> UpdateOrderInfoAsync([FromBody] UpdateOrderInfoRequest orderInfo, CancellationToken cancellationToken)
        {
            UpdateOrderInfoResponse response = new();
            try
            {
                await _orderRetriever.UpdateOrderInfoAsync(orderInfo.OrderID, orderInfo.Status, orderInfo.OrderDelivered, cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION In: " + nameof(UpdateOrderInfoAsync));
                response.HasError = true;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        [HttpPut]
        public async Task<CreateOrderResponse> CreateOrderAsync([FromBody] CreateOrderRequest orderRequest, CancellationToken cancellationToken)
        {
            CreateOrderResponse response = new();
            try
            {
                await _orderRetriever.CreateOrderAsync(orderRequest.Total, orderRequest.CustomerID, cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EXCEPTION In: " + nameof(CreateOrderAsync));
                response.HasError = true;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
    }
}