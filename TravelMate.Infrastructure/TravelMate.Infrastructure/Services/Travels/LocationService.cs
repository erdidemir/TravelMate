using TravelMate.Application.Contracts.Repositories.Commons;
using TravelMate.Application.Services.Travels;
using TravelMate.Domain.Entities.Travels;
using TravelMate.Infrastructure.Services.Commons;

namespace TravelMate.Infrastructure.Services.Settings
{
    public class LocationService : ServiceBase<Location>, ILocationService
    {
        private readonly IReadRepository<Location> _entityReadRepository;
        private readonly IWriteRepository<Location> _entityWriteRepository;

        public LocationService(IReadRepository<Location> entityReadRepository, IWriteRepository<Location> entityWriteRepository) : base(entityReadRepository, entityWriteRepository)
        {
            _entityReadRepository = entityReadRepository ?? throw new ArgumentNullException(nameof(entityReadRepository));
            _entityWriteRepository = entityWriteRepository ?? throw new ArgumentNullException(nameof(entityWriteRepository));

        }
    }
}
