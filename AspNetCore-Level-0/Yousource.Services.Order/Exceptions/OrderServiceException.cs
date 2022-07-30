namespace Yousource.Services.Order.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class OrderServiceException : Exception
    {
        public OrderServiceException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

        public OrderServiceException(Exception innerException)
            : base(string.Empty, innerException)
        {

        }

   

        }
    }
