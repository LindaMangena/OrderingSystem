namespace Yousource.Api.Models.Orders
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Threading.Tasks;

    public class OrderWebModel
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("Item")]
        public string Item { get; set; }

        [JsonProperty("Price")]
        public decimal Price { get; set; }

        [JsonProperty("PlacedOn")]
        public DateTime PlacedOn { get; set; }

        [JsonProperty("SenderEmail")]
        public string SenderEmail { get; set; }

        [JsonProperty("SenderName")]
        public string SenderName { get; set; }

        [JsonProperty("RecipientName")]
        public string RecipientName { get; set; }

        [JsonProperty("RecipientSurname")]
        public string RecipientSurname { get; set; }

        [JsonProperty("RecipientEmail")]
        public string RecipientEmail { get; set; }

        [JsonProperty("Voucher")]
        public int Voucher { get; set; }
    }
}
