using TravelMate.Application.Contracts.Repositories.Commons;
using TravelMate.Domain.Entities.Languages;

namespace TravelMate.Application.Contracts.Repositories.Languages
{
    public interface ILanguageResourceReadRepository : IReadRepository<LanguageResource>
    {
        Task<string> GetTranslateAsync(string translateWord, string languageCode);

    }
}
