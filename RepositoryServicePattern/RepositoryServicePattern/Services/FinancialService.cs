using RepositoryServicePattern.Models;
using RepositoryServicePattern.Repositories;

namespace RepositoryServicePattern.Services
{
    public class FinancialService : IFinancialsService
    {
        private readonly ITicketRepository _ticketRepo;
        private readonly IFoodRepository _foodRepo;

        public FinancialService(ITicketRepository ticketRepo, IFoodRepository foodRepo)
        {
            _ticketRepo = ticketRepo;
            _foodRepo = foodRepo;
        }
        public FinancialStats GetStats()
        {
            FinancialStats stats = new FinancialStats();
            var foodSold = _foodRepo.GetAllSold();
            var ticketsSold = _ticketRepo.GetAllSold();

            stats.AverageTicketProfit =
                ticketsSold.Sum(ticket => ticket.Profit) / ticketsSold.Sum(ticket => ticket.Quantity);
            stats.AverageFoodItemProfit = 
                foodSold.Sum(food => food.Profit) / foodSold.Sum(food => food.Quantity);

            return stats;
        }
    }
}
