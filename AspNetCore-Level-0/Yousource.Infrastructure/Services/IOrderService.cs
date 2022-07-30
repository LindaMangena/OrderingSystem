namespace Yousource.Infrastructure.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Yousource.Infrastructure.Messages.Orders.Requests;
    using Yousource.Infrastructure.Messages.Orders.Responses;

    public interface IOrderService
    {
        Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request);

        Task<GetOrdersByEmailResponse> GetOrdersByEmailAsync(string senderemail);
    }
}
