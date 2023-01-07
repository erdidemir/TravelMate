using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TravelMate.Application.Contracts.Repositories.Commons;
using TravelMate.Application.Contracts.Repositories.Languages;
using TravelMate.Application.Contracts.Repositories.Settings;
using TravelMate.Application.Services.Authentications;
using TravelMate.Application.Services.Commons;
using TravelMate.Application.Services.Languages;
using TravelMate.Application.Services.Settings;
using TravelMate.Infrastructure.Contracts;
using TravelMate.Infrastructure.Contracts.Repositories.Commons;
using TravelMate.Infrastructure.Contracts.Repositories.Languages;
using TravelMate.Infrastructure.Contracts.Repositories.Settings;
using TravelMate.Infrastructure.Services.Authentications;
using TravelMate.Infrastructure.Services.Commons;
using TravelMate.Infrastructure.Services.Languages;
using TravelMate.Infrastructure.Services.Settings;

namespace TravelMate.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                                      options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);

            #region Authentications

            services.AddScoped<IUserService, UserService>();

            #endregion

            #region Commons

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));


            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            #endregion

            #region Language

            services.AddScoped<ILanguageReadRepository, LanguageReadRepository>();
            services.AddScoped<ILanguageWriteRepository, LanguageWriteRepository>();
            services.AddScoped<ILanguageService, LanguageService>();

            services.AddScoped<ILanguageResourceReadRepository, LanguageResourceReadRepository>();
            services.AddScoped<ILanguageResourceWriteRepository, LanguageResourceWriteRepository>();
            services.AddScoped<ILanguageResourceService, LanguageResourceService>();

            #endregion


            #region Settings

            services.AddScoped<ICountryReadRepository, CountryReadRepository>();
            services.AddScoped<ICountryWriteRepository, CountryWriteRepository>();
            services.AddScoped<ICountryService, CountryService>();

            #endregion

            return services;
        }
    }
}