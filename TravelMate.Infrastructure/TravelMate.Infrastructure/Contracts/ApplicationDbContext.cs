using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelMate.Domain.Configurations.Languages;
using TravelMate.Domain.Configurations.Settings;
using TravelMate.Domain.Configurations.Travels;
using TravelMate.Domain.Entities.Authentications;
using TravelMate.Domain.Entities.Commons;
using TravelMate.Domain.Entities.Languages;
using TravelMate.Domain.Entities.Settings;
using TravelMate.Domain.Entities.Travels;

namespace TravelMate.Infrastructure.Contracts
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<EntityBase>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.IsDeleted = false;

                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            #region Settings

            modelBuilder.ApplyConfiguration(new CountryConfiguration());

            #endregion

            #region Languages
            
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageResourceConfiguration());

            #endregion

            #region Travels

            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new TravelConfiguration());
            modelBuilder.ApplyConfiguration(new TravelUserConfiguration());

            #endregion

        }

        #region Settings
        public DbSet<Country> Countries { get; set; }
       
        #endregion

        #region Languages
        public DbSet<Language> Languages { get; set; }
        public DbSet<LanguageResource> LanguageResources { get; set; }

        #endregion

        #region Languages
        public DbSet<Location> Locations { get; set; }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<TravelUser> TravelUsers { get; set; }

        #endregion





    }
}
