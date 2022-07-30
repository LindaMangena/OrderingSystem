using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yousource.Infrastructure.Messages.Orders.Requests;

namespace Yousource.Services.Order.Extensions
{
    public static class OrderExtensions
    {
        public static Infrastructure.Entities.Orders.Order AsEntity(this CreateOrderRequest request)
        {
            var result = new Infrastructure.Entities.Orders.Order
            {
                Item = request.Item,
                SenderEmail = request.SenderEmail,
                SenderName = request.SenderName,
                RecipientName = request.RecipientName,
                RecipientSurname = request.RecipientSurname,
                RecipientEmail = request.RecipientEmail,
                Price = request.Price

            };

            return result;
        }

        public static IEnumerable<Infrastructure.Models.Orders.Order> AsModel(this IEnumerable<Infrastructure.Entities.Orders.Order> entities)
        {
            var result = entities.Select(entity => entity.AsModel());
            return result;
        }

        public static Infrastructure.Models.Orders.Order AsModel(this Infrastructure.Entities.Orders.Order entity)
        {
            var result = new Infrastructure.Models.Orders.Order
            {
                Item = entity.Item,
                SenderEmail = entity.SenderEmail,
                SenderName = entity.SenderName,
                PlacedOn = entity.PlacedOn,
                Id = entity.Id,
                RecipientName = entity.RecipientName,
                RecipientSurname = entity.RecipientSurname,
                RecipientEmail = entity.RecipientEmail,
                Price = entity.Price,
                Voucher = entity.Voucher

            };

            return result;
        }
    }
}
