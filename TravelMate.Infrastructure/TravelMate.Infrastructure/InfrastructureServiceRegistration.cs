using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TravelMate.Infrastructure.Contracts;

namespace TravelMate.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                                      options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);


            return services;
        }
    }
}