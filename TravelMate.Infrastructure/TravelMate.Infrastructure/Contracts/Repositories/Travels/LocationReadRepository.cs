using TravelMate.Application.Contracts.Repositories.Travels;
using TravelMate.Domain.Entities.Travels;
using TravelMate.Infrastructure.Contracts.Repositories.Commons;

namespace TravelMate.Infrastructure.Contracts.Repositories.Travels
{
    public class LocationReadRepository : ReadRepository<Location>, ILocationReadRepository
    {
        public LocationReadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
