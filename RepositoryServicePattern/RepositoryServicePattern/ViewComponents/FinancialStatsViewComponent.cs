using Microsoft.AspNetCore.Mvc;
using RepositoryServicePattern.Services;

namespace RepositoryServicePattern.ViewComponents
{
    public class FinancialStatsViewComponent : ViewComponent
    {
        private readonly IFinancialsService _financialService;

        public FinancialStatsViewComponent(IFinancialsService financialService)
        {
            _financialService = financialService;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            var stats = _financialService.GetStats();
            return Task.FromResult<IViewComponentResult>(View(stats));
        }
    }
}
