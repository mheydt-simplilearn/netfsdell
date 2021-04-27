using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopStore.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }

        public List<CartItem> Items { get; set; }
    }
}
