using System.Collections.Generic;
using System.Linq;
using TranGiaBao_0230_lab02.Models;
namespace TranGiaBao_0230_lab02.Repositories
{
    public class MockProductRepository : IProductRepository
    {
        private readonly List<Product> _products;
        public MockProductRepository()
        {
            // Tạo một số dữ liệu mẫu
            _products = new List<Product>
            {
                    new Product { Id = 1, Name = "Laptop", Price = 100000000,Description = "A high laptop",ImageUrl="",CategoryId = 1},
                    new Product { Id = 2, Name = "mac", Price = 100000000, Description = "A high-end laptop",ImageUrl="", CategoryId = 1 },
                    new Product { Id = 3, Name = "Smartphone", Price = 50000000, Description = "A latest model smartphone",ImageUrl="", CategoryId = 3 },
                    new Product { Id = 4, Name = "Tablet", Price = 30000000, Description = "A portable tablet for work and play",ImageUrl="", CategoryId = 2 }

            };
        }
        public IEnumerable<Product> GetAll()
        {
            return _products;
        }
        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
        public void Add(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }
        public void Update(Product product)
        {
            var index = _products.FindIndex(p => p.Id == product.Id);
            if (index != -1)
            {
                _products[index] = product;
            }
        }
        public void Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}
