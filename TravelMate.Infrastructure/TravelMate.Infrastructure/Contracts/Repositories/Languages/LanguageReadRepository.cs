using TravelMate.Application.Contracts.Repositories.Languages;
using TravelMate.Domain.Entities.Languages;
using TravelMate.Infrastructure.Contracts.Repositories.Commons;

namespace TravelMate.Infrastructure.Contracts.Repositories.Languages
{
    public class LanguageReadRepository : ReadRepository<Language>, ILanguageReadRepository
    {
        public LanguageReadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
