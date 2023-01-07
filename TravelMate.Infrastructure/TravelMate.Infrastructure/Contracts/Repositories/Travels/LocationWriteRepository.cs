using TravelMate.Application.Contracts.Repositories.Travels;
using TravelMate.Domain.Entities.Travels;
using TravelMate.Infrastructure.Contracts.Repositories.Commons;

namespace TravelMate.Infrastructure.Contracts.Repositories.Travels
{
    public class LocationWriteRepository : WriteRepository<Location>, ILocationWriteRepository
    {
        public LocationWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
