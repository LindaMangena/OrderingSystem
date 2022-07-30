namespace Yousource.Api.Extensions.Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Yousource.Api.Messages;
    using Yousource.Api.Messages.Orders;
    using Yousource.Api.Messages.Orders.Requests;
    using Yousource.Api.Models.Orders;
    using Yousource.Infrastructure.Messages.Orders.Requests;
    using Yousource.Infrastructure.Messages.Orders.Responses;
    using Yousource.Infrastructure.Models.Orders;

    public static class OrderExtensions
    {
        public static CreateOrderRequest AsRequest(this CreateOrderWebRequest request)
        {
            var result = new CreateOrderRequest
            {
                Item = request.Item,
                SenderEmail = request.SenderEmail,
                SenderName = request.SenderName,
                RecipientName = request.RecipientName,
                RecipientSurname = request.RecipientSurname,
                RecipientEmail = request.RecipientEmail,
                Price = request.Price,

            };

            return result;
        }

        public static WebResponse AsWebResponse(this CreateOrderResponse response)
        {
            var result = new WebResponse
            {
                Message = response.Message,
                ErrorCode = response.ErrorCode,
                StatusCode = response.StatusCode
            };

            return result;
        }

        public static WebResponse<IEnumerable<OrderWebModel>> AsWebResponse(this GetOrdersByEmailResponse response)
        {
            var result = new WebResponse<IEnumerable<OrderWebModel>>(response.Data?.AsWebModel())
            {
                Message = response.Message,
                ErrorCode = response.ErrorCode,
                StatusCode = response.StatusCode

            };

            return result;
        }

        public static OrderWebModel AsWebModel(this Order model)
        {
            return new OrderWebModel
            {
                Id = model.Id,
                Item = model.Item,
                SenderEmail = model.SenderEmail,
                SenderName = model.SenderName,
                PlacedOn = model.PlacedOn,
                RecipientName = model.RecipientName,
                RecipientSurname = model.RecipientSurname,
                RecipientEmail = model.RecipientEmail,
                Price = model.Price,
            };
        }

        public static IEnumerable<OrderWebModel> AsWebModel(this IEnumerable<Order> models)
        {
            return models.Select(entity => entity.AsWebModel());
        }
    }
}
