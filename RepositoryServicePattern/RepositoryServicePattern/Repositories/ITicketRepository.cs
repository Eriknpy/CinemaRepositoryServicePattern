using RepositoryServicePattern.Models;

namespace RepositoryServicePattern.Repositories
{
    public interface ITicketRepository
    {
        public List<Ticket> GetAllSold();
    }
}
