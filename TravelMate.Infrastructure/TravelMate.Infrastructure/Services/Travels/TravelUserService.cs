using TravelMate.Application.Contracts.Repositories.Commons;
using TravelMate.Application.Services.Travels;
using TravelMate.Domain.Entities.Travels;
using TravelMate.Infrastructure.Services.Commons;

namespace TravelMate.Infrastructure.Services.Settings
{
    public class TravelUserService : ServiceBase<TravelUser>, ITravelUserService
    {
        private readonly IReadRepository<TravelUser> _entityReadRepository;
        private readonly IWriteRepository<TravelUser> _entityWriteRepository;

        public TravelUserService(IReadRepository<TravelUser> entityReadRepository, IWriteRepository<TravelUser> entityWriteRepository) : base(entityReadRepository, entityWriteRepository)
        {
            _entityReadRepository = entityReadRepository ?? throw new ArgumentNullException(nameof(entityReadRepository));
            _entityWriteRepository = entityWriteRepository ?? throw new ArgumentNullException(nameof(entityWriteRepository));

        }
    }
}
