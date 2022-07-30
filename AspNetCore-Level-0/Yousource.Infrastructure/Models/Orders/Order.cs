namespace Yousource.Infrastructure.Models.Orders
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Runtime.Serialization;

    [DataContract]
    public class Order
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Item { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public DateTime PlacedOn {get;set;}

        [DataMember]
        public string SenderEmail { get; set; }

        [DataMember]
        public string SenderName { get; set; }

        [DataMember]
        public string RecipientName { get; set; }

        [DataMember]
        public string RecipientSurname { get; set; }

        [DataMember]
        public string RecipientEmail { get; set; }  

        [DataMember]
        public int Voucher { get; set; }
    }
}
