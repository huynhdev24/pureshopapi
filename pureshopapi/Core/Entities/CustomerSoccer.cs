using System.Collections.Generic;

namespace pureshopapi.Core.Entities
{
    public class CustomerSoccer
    {
        public CustomerSoccer() { }
        public CustomerSoccer(string id) 
        {
            id = id;
        }

        public string Id { get; set; }
        public List<SoccerItem> Items { get; set; } = new List<SoccerItem>();
        public int? DeliveryMethodId { get; set; }
        public string ClientSecret { get; set; }
        public string PaymentIntentId { get; set; }
        public decimal ShippingPrice { get; set; }
    }
}
