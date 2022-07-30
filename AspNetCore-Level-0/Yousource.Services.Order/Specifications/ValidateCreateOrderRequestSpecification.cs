using System;
using System.Collections.Generic;
using System.Text;
using Yousource.Infrastructure.Messages.Orders.Requests;

namespace Yousource.Services.Order.Specifications
{
    class ValidateCreateOrderRequestSpecification
    {
        internal bool IsSatisfiedBy(CreateOrderRequest entity, ref ICollection<string> errors)
        {

            if (string.IsNullOrEmpty(entity.SenderName))
            {
                errors.Add("Customer name is required");
            }

            var result = errors.Count == 0;
            return result;
        }
    }
}
