using TravelMate.Application.Contracts.Repositories.Settings;
using TravelMate.Domain.Entities.Settings;
using TravelMate.Infrastructure.Contracts.Repositories.Commons;

namespace TravelMate.Infrastructure.Contracts.Repositories.Settings
{
    public class CountryReadRepository : ReadRepository<Country>, ICountryReadRepository
    {
        public CountryReadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
