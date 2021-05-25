using LaptopStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopStore.Repositories
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> FindAsync(int id);
        void Update(Product product);
        void Add(Product product);
        Task RemoveByIdAsync(int id);
        Task<bool> ExistsByIdAsync(int id);
        Task SaveChangesAsync();
    }
}
