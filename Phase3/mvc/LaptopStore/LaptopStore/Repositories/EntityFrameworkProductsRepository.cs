using LaptopStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaptopStore.Repositories
{
    public class EntityFrameworkProductsRepository : IProductsRepository
    {
        public Task<IEnumerable<Product>> GetAllAsync()
        {
            return null;
        }

        public Task<Product> FindAsync(int id)
        {
            return null;
        }

        public void Update(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> ExistsByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
