using TravelMate.Application.Contracts.Repositories.Commons;
using TravelMate.Application.Services.Languages;
using TravelMate.Domain.Entities.Languages;
using TravelMate.Infrastructure.Services.Commons;

namespace TravelMate.Infrastructure.Services.Languages
{
    public class LanguageService : ServiceBase<Language>, ILanguageService
    {
        private readonly IReadRepository<Language> _entityReadRepository;
        private readonly IWriteRepository<Language> _entityWriteRepository;

        public LanguageService(IReadRepository<Language> entityReadRepository, IWriteRepository<Language> entityWriteRepository) : base(entityReadRepository, entityWriteRepository)
        {
            _entityReadRepository = entityReadRepository ?? throw new ArgumentNullException(nameof(entityReadRepository));
            _entityWriteRepository = entityWriteRepository ?? throw new ArgumentNullException(nameof(entityWriteRepository));

        }
    }
}
