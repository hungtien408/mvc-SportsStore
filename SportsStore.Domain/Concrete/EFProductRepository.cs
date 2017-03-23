using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;


namespace SportsStore.Domain.Concrete
{
    public class EFProductRepository : IProductsRepository
    {
        // Khởi tạo dataset
        private EFDbContext context = new EFDbContext();
        // gán dữ liệu dataset vào đối tượng Product trong IProductRepository
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
