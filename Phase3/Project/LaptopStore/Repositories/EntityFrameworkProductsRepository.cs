using LaptopStore.Data;
using LaptopStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopStore.Repositories
{
    public class EntityFrameworkProductsRepository : IProductsRepository
    {
        private LaptopStoreContext _dbContext;
        public EntityFrameworkProductsRepository(LaptopStoreContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<Product>>(_dbContext.Product.ToList());
        }

        public async Task<Product> FindAsync(int productId)
        {
            return await _dbContext.Product.FindAsync(productId);
        }

        public void Update(Product product)
        {
            _dbContext.Update(product);
        }

        public void Add(Product product)
        {
            _dbContext.Add(product);
        }

        public Task RemoveByIdAsync(int productId)
        {
            //var product = _dbContext.Product.Find(productId);
            //_dbContext.Product.Remove(product);
            _dbContext.Product.Remove(new Product() { ID = productId });
            return Task.CompletedTask;
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(int productId)
        {
            return (await _dbContext.Product.FindAsync(productId)) != null;
        }
    }
}
