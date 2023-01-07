using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using TravelMate.Domain.Entities.Authentications;
using TravelMate.Infrastructure.Contracts.Seeds.Authentications;
using TravelMate.Infrastructure.Contracts.Seeds.Languages;
using TravelMate.Infrastructure.Contracts.Seeds.Settings;

namespace TravelMate.Infrastructure.Contracts
{
    public class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext applicationContext,
            ILogger<ApplicationDbContextSeed> logger,
            UserManager<User> userManager,
            RoleManager<Role> roleManager)
        {
            #region User

            if (!applicationContext.Users.Any())
            {
                applicationContext.Users.AddRange(UserSeed.UserList());
                await applicationContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", applicationContext.GetType().Name);
            }

            #endregion

            #region Role

            if (!applicationContext.Roles.Any())
            {
                applicationContext.Roles.AddRange(RoleSeed.RoleList());
                await applicationContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", applicationContext.GetType().Name);

            }

            #endregion

            #region UserRole

            if (!applicationContext.UserRoles.Any())
            {
                applicationContext.UserRoles.AddRange(UserRoleSeed.UserRoleList());
                await applicationContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", applicationContext.GetType().Name);

            }

            #endregion

            #region Language

            if (!applicationContext.Languages.Any())
            {
                applicationContext.Languages.AddRange(LanguageSeed.LanguageList());
                await applicationContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", applicationContext.GetType().Name);

            }
            #endregion

            #region Country

            if (!applicationContext.Countries.Any())
            {
                applicationContext.Countries.AddRange(CountrySeed.CountryList());
                await applicationContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", applicationContext.GetType().Name);
            }
            #endregion

            #region LanguageResource

            if (!applicationContext.LanguageResources.Any())
            {
                applicationContext.LanguageResources.AddRange(LanguageResourceDESeed.LanguageResourceList());
                applicationContext.LanguageResources.AddRange(LanguageResourceENSeed.LanguageResourceList());
                applicationContext.LanguageResources.AddRange(LanguageResourceRUSeed.LanguageResourceList());
                applicationContext.LanguageResources.AddRange(LanguageResourceTRSeed.LanguageResourceList());
                await applicationContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", applicationContext.GetType().Name);
            }
            #endregion
          
            logger.LogInformation("Seed database associated with context {DbContextName}", typeof(ApplicationDbContext).Name);
        }

    }
}
