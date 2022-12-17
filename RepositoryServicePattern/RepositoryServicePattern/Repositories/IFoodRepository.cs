using RepositoryServicePattern.Models;

namespace RepositoryServicePattern.Repositories
{
    public interface IFoodRepository
    {
        public List<FoodItem> GetAllSold();
    }
}
