namespace Yousource.Api.Messages.Orders.Requests
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class CreateOrderWebRequest: WebRequest
    {
        [JsonProperty("item")]
        [Required]
        public string Item { get; set; }

        [JsonProperty("sendername")]
        [Required]
        public string SenderName { get; set; }

        [JsonProperty("senderemail")]
        [Required]
        public string SenderEmail { get; set; }

        [JsonProperty("recipientname")]
        [Required]
        public string RecipientName { get; set; }

        [JsonProperty("recipientsurname")]
        [Required]
        public string RecipientSurname { get; set; }

        public string RecipientEmail { get; set; }

        [JsonProperty("voucher")]
        [Required]
        public int Voucher { get; set; }

        [JsonProperty("price")]
        [Required]
        public decimal Price { get; set; }


    }
}
