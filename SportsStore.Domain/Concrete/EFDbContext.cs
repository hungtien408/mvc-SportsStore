using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Entities;
using System.Data.Entity;

namespace SportsStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        // Lấy dữ liệu Product trong database gán vào dataset
        public DbSet<Product> Products { get; set; }
    }
}
