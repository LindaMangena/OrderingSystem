namespace Yousource.Infrastructure.Messages.Orders.Responses
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Yousource.Infrastructure.Models.Orders;

  public class GetOrdersByEmailResponse : Response
    {
        [DataMember]
        public IEnumerable<Order> Data { get; set; }
    }
}
