using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LaptopStore.Models;

namespace LaptopStore.Data
{
    public class LaptopStoreContext : DbContext
    {
        public LaptopStoreContext (DbContextOptions<LaptopStoreContext> options)
            : base(options)
        {
        }

        public DbSet<LaptopStore.Models.Product> Product { get; set; }
    }
}
