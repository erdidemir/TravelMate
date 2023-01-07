using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Application.Contracts.Repositories.Commons;
using TravelMate.Application.Services.Settings;
using TravelMate.Domain.Entities.Settings;
using TravelMate.Infrastructure.Services.Commons;

namespace TravelMate.Infrastructure.Services.Settings
{
    public class CountryService : ServiceBase<Country>, ICountryService
    {
        private readonly IReadRepository<Country> _entityReadRepository;
        private readonly IWriteRepository<Country> _entityWriteRepository;

        public CountryService(IReadRepository<Country> entityReadRepository, IWriteRepository<Country> entityWriteRepository) : base(entityReadRepository, entityWriteRepository)
        {
            _entityReadRepository = entityReadRepository ?? throw new ArgumentNullException(nameof(entityReadRepository));
            _entityWriteRepository = entityWriteRepository ?? throw new ArgumentNullException(nameof(entityWriteRepository));

        }
    }
}
