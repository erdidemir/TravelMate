using TravelMate.Application.Contracts.Repositories.Commons;
using TravelMate.Application.Services.Travels;
using TravelMate.Domain.Entities.Travels;
using TravelMate.Infrastructure.Services.Commons;

namespace TravelMate.Infrastructure.Services.Settings
{
    public class TravelService : ServiceBase<Travel>, ITravelService
    {
        private readonly IReadRepository<Travel> _entityReadRepository;
        private readonly IWriteRepository<Travel> _entityWriteRepository;

        public TravelService(IReadRepository<Travel> entityReadRepository, IWriteRepository<Travel> entityWriteRepository) : base(entityReadRepository, entityWriteRepository)
        {
            _entityReadRepository = entityReadRepository ?? throw new ArgumentNullException(nameof(entityReadRepository));
            _entityWriteRepository = entityWriteRepository ?? throw new ArgumentNullException(nameof(entityWriteRepository));

        }
    }
}
