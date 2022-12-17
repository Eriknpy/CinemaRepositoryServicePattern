using RepositoryServicePattern.Models;

namespace RepositoryServicePattern.Services
{
    public interface ITicketService
    {
        List<Ticket> GetAllSold();
    }
}
