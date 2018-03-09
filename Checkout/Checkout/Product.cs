using System;
using System.Collections.Generic;
using System.Text;

namespace Checkout
{
  public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public bool IsVisible { get; set; }
    }
   
}

