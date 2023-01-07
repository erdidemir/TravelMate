using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Application.Contracts.Repositories.Commons;
using TravelMate.Application.Contracts.Repositories.Languages;
using TravelMate.Application.Services.Languages;
using TravelMate.Domain.Entities.Languages;
using TravelMate.Infrastructure.Services.Commons;

namespace TravelMate.Infrastructure.Services.Languages
{
    public class LanguageResourceService : ServiceBase<LanguageResource>, ILanguageResourceService
    {
        private readonly IReadRepository<LanguageResource> _entityReadRepository;
        private readonly IWriteRepository<LanguageResource> _entityWriteRepository;
        private readonly ILanguageResourceReadRepository _languageResourceReadRepository;
        public LanguageResourceService(IReadRepository<LanguageResource> entityReadRepository, IWriteRepository<LanguageResource> entityWriteRepository, ILanguageResourceReadRepository languageResourceReadRepository) : base(entityReadRepository, entityWriteRepository)
        {
            _entityReadRepository = entityReadRepository ?? throw new ArgumentNullException(nameof(entityReadRepository));
            _entityWriteRepository = entityWriteRepository ?? throw new ArgumentNullException(nameof(entityWriteRepository));
            _languageResourceReadRepository = languageResourceReadRepository;
        }

        public Task<string> GetTranslateAsync(string translateWord, string languageCode)
        {
            return _languageResourceReadRepository.GetTranslateAsync(translateWord, languageCode);
        }
    }
}
