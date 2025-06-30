using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StorageApi.Models.Entities;

namespace StorageApi.Data
{
    public class StorageContext : DbContext
    {
        public StorageContext (DbContextOptions<StorageContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = default!;
    }
}
