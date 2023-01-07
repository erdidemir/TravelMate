using TravelMate.Application.Contracts.Repositories.Commons;
using TravelMate.Domain.Entities.Travels;

namespace TravelMate.Application.Contracts.Repositories.Travels
{
    public interface ITravelWriteRepository : IWriteRepository<Travel>
    {
    }
}
