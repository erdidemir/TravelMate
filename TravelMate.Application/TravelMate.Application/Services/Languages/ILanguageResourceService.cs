using TravelMate.Application.Services.Commons;
using TravelMate.Domain.Entities.Languages;

namespace TravelMate.Application.Services.Languages
{
    public interface ILanguageResourceService : IServiceBase<LanguageResource>
    {
        Task<string> GetTranslateAsync(string translateWord, string languageCode);

    }
}
