using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskSoftline.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Price> Prices { get; set; }
        public Product()
        {
            Prices = new List<Price>();
        }
    }
}