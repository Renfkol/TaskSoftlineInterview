using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskSoftline.Models
{
    public class Price
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public int? ProductId { get; set; }
        public int? ProviderId { get; set; }
        public Product Product { get; set; }
    }
}