using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelMate.Domain.Configurations.Settings;
using TravelMate.Domain.Entities.Authentications;
using TravelMate.Domain.Entities.Commons;
using TravelMate.Domain.Entities.Settings;

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
                        entry.Entity.IsActive = true;
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

        }

        #region Settings
        public DbSet<Country> Countries { get; set; }
        #endregion

     

    }
}
