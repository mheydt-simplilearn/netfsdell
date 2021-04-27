using LaptopStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopStore.Repositories
{
    public class LaptopStoreRepository : ILaptopStoreRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            return new[]
            {
                new Product()
                {
                    ID = 1,
                    Brand = "Dell",
                    Name = "Inspiron 15 3000",
                    Price = 579.99m,
                    Thumbnail = "Inspiron15_3000_thumb.png"
                },
                new Product()
                {
                    ID = 1,
                    Brand = "Dell",
                    Name = "Inspiron 15 3000",
                    Price = 2349.99m,
                    Thumbnail = "xps15_thumb.png"
                }
            };
        }
    }
}
