using TranGiaBao_0230_lab02.Models;

namespace TranGiaBao_0230_lab02.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
    