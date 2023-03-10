using Microsoft.AspNetCore.Mvc;
using RepositoryServicePattern.Services;

namespace RepositoryServicePattern.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }
        public IActionResult Index()
        {
            var tickets = _ticketService.GetAllSold();
            return View(tickets);
        }
    }
}
