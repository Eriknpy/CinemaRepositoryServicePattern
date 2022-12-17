using Microsoft.AspNetCore.Mvc;
using RepositoryServicePattern.Services;

namespace RepositoryServicePattern.Controllers
{
    public class FinancialController : Controller
    {
        private readonly IFinancialsService _financialService;

        public FinancialController(IFinancialsService financialService)
        {
            _financialService = financialService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
