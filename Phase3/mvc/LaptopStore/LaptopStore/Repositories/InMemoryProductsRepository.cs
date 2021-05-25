using LaptopStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace LaptopStore.Repositories
{
    public class InMemoryProductsRepository : IProductsRepository
    {
        private static List<Product> _products = new List<Product>()
        {
            new Product()
            {
                ID = 1,
                Name = "XPS15",
                Price = 2249.99m,
                Thumbnail = "xps15_thumb.png"
            },
            new Product()
            {
                ID = 2,
                Brand = "Dell",
                Name = "Inspiron 15 3000",
                Price = 2349.99m,
                Thumbnail = "Inspiron15_3000t_thumb.PNG"
            }
        };

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public Task<bool> ExistsByIdAsync(int id)
        {
            return Task.FromResult(_products.FirstOrDefault(product => product.ID == id) != null);
        }

        public Task<Product> FindAsync(int productId)
        {
            return Task.FromResult(_products.FirstOrDefault(p => p.ID == productId));
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            return Task.FromResult((IEnumerable<Product>)_products);
        }

        public Task RemoveByIdAsync(int id)
        {
            var product = _products.FirstOrDefault(product => product.ID == id);
            if (product != null) _products.Remove(product);
            return Task.CompletedTask;
        }

        public Task SaveChangesAsync()
        {
            return Task.CompletedTask;
        }

        public void Update(Product product)
        {
        }
    }
}
