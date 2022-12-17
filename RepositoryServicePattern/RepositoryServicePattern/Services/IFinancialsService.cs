using RepositoryServicePattern.Models;

namespace RepositoryServicePattern.Services
{
    public interface IFinancialsService
    {
        public FinancialStats GetStats();
    }
}
