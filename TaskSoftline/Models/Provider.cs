using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskSoftline.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string ProviderName{ get; set; }

        public int DeliveryDays { get; set; }

        public ICollection<Price> PriceLists { get; set; }
        public Provider()
        {
            PriceLists = new List<Price>();
        }
    }
}