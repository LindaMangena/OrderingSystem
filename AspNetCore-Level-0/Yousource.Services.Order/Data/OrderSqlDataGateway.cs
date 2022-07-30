using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using Yousource.Infrastructure.Data;
using Yousource.Infrastructure.Helpers;
using Yousource.Infrastructure.Logging;
using Yousource.Services.Order.Exceptions;

namespace Yousource.Services.Order.Data
{
    public class OrderSqlDataGateway : IOrderDataGateway
    {
        private readonly ISqlHelper sql;
        private readonly ILogger logger;

        public OrderSqlDataGateway(
            ISqlHelper helper,
            ILogger logger)
        {
            this.sql = helper;
            this.logger = logger;
        }

        public async Task<IEnumerable<Infrastructure.Entities.Orders.Order>> GetOrdersByEmailAsync(string senderemail)
        {
            var result = new List<Infrastructure.Entities.Orders.Order>();

            try
            {
                var command = OrderSqlCommandFactory.CreateGetOrdersByEmailCommand(senderemail);
                result = await this.sql.ReadAsListAsync<Infrastructure.Entities.Orders.Order>(command);
            }
            catch (DbException ex)
            {
                this.logger.WriteException(ex);
                throw new OrderDataException(ex);
            }

            return result;
        }

        public async Task InsertOrderAsync(Infrastructure.Entities.Orders.Order order)
        {
            try
            {
                var command = OrderSqlCommandFactory.CreateInsertOrderCommand(order);
                await this.sql.ExecuteAsync(command);
            }
            catch (DbException ex)
            {
                this.logger.WriteException(ex);
                throw new OrderDataException(ex);
            }
        }
    }
}
