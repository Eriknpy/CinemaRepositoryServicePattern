using RepositoryServicePattern.Models;
using RepositoryServicePattern.Repositories;

namespace RepositoryServicePattern.Services
{
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository _foodRepo;

        public FoodService(IFoodRepository foodRepo)
        {
            _foodRepo = foodRepo;
        }
        public List<FoodItem> GetAllSold()
        {
            return _foodRepo.GetAllSold();
        }
    }
}
