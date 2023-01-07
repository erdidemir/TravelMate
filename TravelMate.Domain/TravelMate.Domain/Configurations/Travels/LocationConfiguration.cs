using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelMate.Domain.Configurations.Commons;
using TravelMate.Domain.Entities.Travels;

namespace TravelMate.Domain.Configurations.Travels
{
    public class LocationConfiguration : EntityTypeConfigurationBase<Location>
    {
        public override void Configure(EntityTypeBuilder<Location> entity)
        {

            base.Configure(entity);

            entity.Property(p => p.CountryId).IsRequired();
            entity.Property(p => p.CityName).IsRequired();
            entity.Property(p => p.IsActive).IsRequired();

            #region ForeingKey

            entity.HasOne(x => x.Country).WithMany(x => x.Locations).HasForeignKey(x => x.CountryId);

            #endregion

            #region Index


            #endregion
        }
    }
}
