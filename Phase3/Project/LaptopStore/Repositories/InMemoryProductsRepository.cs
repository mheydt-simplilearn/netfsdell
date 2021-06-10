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
        private static Dictionary<int, Product> _products = new Dictionary<int, Product>()
        {
            {1,  new Product()
            {
                ID = 1,
                Name = "XPS15",
                Price = 2249.99m,
                Thumbnail = "xps15_thumb.png"
            } },
            {2, new Product()
            {
                ID = 2,
                Brand = "Dell",
                Name = "Inspiron 15 3000",
                Price = 2349.99m,
                Thumbnail = "Inspiron15_3000t_thumb.PNG"
            } }
        };

        public void Add(Product product)
        {
            _products[product.ID] = product;
        }

        public Task<bool> ExistsByIdAsync(int id)
        {
            return Task.FromResult(_products.ContainsKey(id));
        }

        public Task<Product> FindAsync(int productId)
        {
            return Task.FromResult(_products[productId]);
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            return Task.FromResult((IEnumerable<Product>)_products.Values);
        }

        public Task RemoveByIdAsync(int productId)
        {
            _products.Remove(productId);
            return Task.CompletedTask;
        }

        public Task SaveChangesAsync()
        {
            return Task.CompletedTask;
        }

        public void Update(Product product)
        {
            if (!_products.ContainsKey(product.ID)) throw new Exception($"Product not found: {product.ID}");
            _products[product.ID] = product;
        }
    }
}
