using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelMate.Domain.Configurations.Commons;
using TravelMate.Domain.Entities.Travels;

namespace TravelMate.Domain.Configurations.Travels
{
    public class TravelConfiguration : EntityTypeConfigurationBase<Travel>
    {
        public override void Configure(EntityTypeBuilder<Travel> entity)
        {

            base.Configure(entity);

            entity.Property(p => p.DepartLocationId).IsRequired();
            entity.Property(p => p.DepartTime).IsRequired();
            entity.Property(p => p.ArriveLocationId).IsRequired();

            #region ForeingKey

            entity.HasOne(x => x.ArriveLocation).WithMany(x => x.ArriveTravels).HasForeignKey(x => x.ArriveLocationId);
            entity.HasOne(x => x.DepartLocation).WithMany(x => x.DepartTravels).HasForeignKey(x => x.DepartLocationId);

            #endregion

            #region Index


            #endregion
        }
    }
}
