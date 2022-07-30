namespace Yousource.Services.Order.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using Yousource.Infrastructure.Entities.Orders;


    public static class OrderSqlCommandFactory
    {
        public static SqlCommand CreateGetOrdersByEmailCommand(string senderemail)
        {
            var result = new SqlCommand("[dbo].[sp_GetOrdersByEmail]")
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 60
            };

            result.Parameters.AddWithValue("@senderemail", senderemail);

            return result;
        }

        public static SqlCommand CreateInsertOrderCommand(Infrastructure.Entities.Orders.Order order)
        {
            var result = new SqlCommand("[dbo].[sp_InsertOrder]")
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 60
            };

            result.Parameters.AddWithValue("@item", order.Item);
            result.Parameters.AddWithValue("@sendername", order.SenderName);
            result.Parameters.AddWithValue("@senderemail", order.SenderEmail);
            result.Parameters.AddWithValue("@recipientname", order.RecipientName);
            result.Parameters.AddWithValue("@recipientsurname", order.RecipientSurname);
            result.Parameters.AddWithValue("@recipientemail", order.RecipientEmail);
            result.Parameters.AddWithValue("@voucher", order.Voucher);
            result.Parameters.AddWithValue("@price", order.Price);

            return result;
        }


    }
}
