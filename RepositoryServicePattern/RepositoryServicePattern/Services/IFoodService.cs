using RepositoryServicePattern.Models;

namespace RepositoryServicePattern.Services
{
    public interface IFoodService
    {
        List<FoodItem> GetAllSold();
    }
}
