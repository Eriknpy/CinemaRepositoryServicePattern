using RepositoryServicePattern.Models;
using RepositoryServicePattern.Repositories;

namespace RepositoryServicePattern.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepo;

        public TicketService(ITicketRepository ticketRepo)
        {
            _ticketRepo = ticketRepo;
        }
        public List<Ticket> GetAllSold()
        {
            return _ticketRepo.GetAllSold();
        }
    }
}
