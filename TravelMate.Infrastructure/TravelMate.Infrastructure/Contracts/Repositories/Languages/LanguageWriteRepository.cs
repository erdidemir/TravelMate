using TravelMate.Application.Contracts.Repositories.Languages;
using TravelMate.Domain.Entities.Languages;
using TravelMate.Infrastructure.Contracts.Repositories.Commons;

namespace TravelMate.Infrastructure.Contracts.Repositories.Languages
{
    public class LanguageWriteRepository : WriteRepository<Language>, ILanguageWriteRepository
    {
        public LanguageWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
