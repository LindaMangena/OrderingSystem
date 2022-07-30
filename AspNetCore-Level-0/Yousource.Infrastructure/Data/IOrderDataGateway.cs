namespace Yousource.Infrastructure.Data
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Yousource.Infrastructure.Entities.Orders;

    public interface IOrderDataGateway
    {
        Task InsertOrderAsync(Order order);
        Task<IEnumerable<Order>> GetOrdersByEmailAsync(string senderemail);
    }
}
