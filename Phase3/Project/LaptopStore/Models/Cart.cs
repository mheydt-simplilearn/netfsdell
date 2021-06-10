using Newtonsoft.Json;
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

        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public CartItem FindItemByProductId(int productId)
        {
            return Items.FirstOrDefault(item => item.Product.ID == productId);
        }

        public void Add(CartItem item)
        {
            Items.Add(item);
        }

        public void Remove(CartItem item)
        {
            Items.Remove(item);
        }
    }
}
