using Microsoft.EntityFrameworkCore;
using TravelMate.Application.Contracts.Repositories.Languages;
using TravelMate.Domain.Entities.Languages;
using TravelMate.Infrastructure.Contracts.Repositories.Commons;

namespace TravelMate.Infrastructure.Contracts.Repositories.Languages
{
    public class LanguageResourceReadRepository : ReadRepository<LanguageResource>, ILanguageResourceReadRepository
    {
        private readonly ApplicationDbContext _context;
        public LanguageResourceReadRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<string> GetTranslateAsync(string translateWord, string languageCode)
        {
            if (languageCode is null)
            {
                languageCode = "en-US";
            }
            var translateResult = await _context.Set<LanguageResource>().Where(x => x.LanguageCode.ToUpper() == languageCode.ToUpper() && x.Name == translateWord).Select(x => x.Value).SingleOrDefaultAsync();

            if (translateResult is null)
            {
                return translateWord;
            }
            return translateResult;

        }
    }
}
