using TravelMate.Application.Contracts.Repositories.Languages;
using TravelMate.Domain.Entities.Languages;
using TravelMate.Infrastructure.Contracts.Repositories.Commons;

namespace TravelMate.Infrastructure.Contracts.Repositories.Languages
{
    public class LanguageResourceWriteRepository : WriteRepository<LanguageResource>, ILanguageResourceWriteRepository
    {
        public LanguageResourceWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
