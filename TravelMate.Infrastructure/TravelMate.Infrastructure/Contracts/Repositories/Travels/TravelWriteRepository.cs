using TravelMate.Application.Contracts.Repositories.Travels;
using TravelMate.Domain.Entities.Travels;
using TravelMate.Infrastructure.Contracts.Repositories.Commons;

namespace TravelMate.Infrastructure.Contracts.Repositories.Travels
{
    public class TravelWriteRepository : WriteRepository<Travel>, ITravelWriteRepository
    {
        public TravelWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
