namespace Yousource.Infrastructure.Entities.Orders
{
    using System;


    public class Order
    {

        public Guid Id { get; set; }


        public string Item { get; set; }


        public decimal Price { get; set; }


        public DateTime PlacedOn { get; set; }


        public string SenderEmail { get; set; }


        public string SenderName { get; set; }

        public string RecipientName { get; set; }

        public string RecipientSurname { get; set; }

        public string RecipientEmail { get; set; }

        public int Voucher { get; set; }

    }
}
