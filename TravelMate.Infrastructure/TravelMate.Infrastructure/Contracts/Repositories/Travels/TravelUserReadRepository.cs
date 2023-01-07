using TravelMate.Application.Contracts.Repositories.Travels;
using TravelMate.Domain.Entities.Travels;
using TravelMate.Infrastructure.Contracts.Repositories.Commons;

namespace TravelMate.Infrastructure.Contracts.Repositories.Travels
{
    public class TravelUserReadRepository : ReadRepository<TravelUser>, ITravelUserReadRepository
    {
        public TravelUserReadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
