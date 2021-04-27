using LaptopStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopStore.Repositories
{
    public interface ILaptopStoreRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
