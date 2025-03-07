using TranGiaBao_0230_lab02.Models;
using System.Collections.Generic;

namespace TranGiaBao_0230_lab02.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
