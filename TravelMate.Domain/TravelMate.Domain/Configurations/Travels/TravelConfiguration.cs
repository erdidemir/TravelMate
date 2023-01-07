using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelMate.Domain.Configurations.Commons;
using TravelMate.Domain.Entities.Travels;

namespace TravelMate.Domain.Configurations.Travels
{
    public class TravelUserConfiguration : EntityTypeConfigurationBase<TravelUser>
    {
        public override void Configure(EntityTypeBuilder<TravelUser> entity)
        {

            base.Configure(entity);

            entity.Property(p => p.UserId).IsRequired();
            entity.Property(p => p.TravelId).IsRequired();
           
            #region ForeingKey

            entity.HasOne(x => x.Travel).WithMany(x => x.TravelUsers).HasForeignKey(x => x.TravelId);
            entity.HasOne(x => x.User).WithMany(x => x.TravelUsers).HasForeignKey(x => x.UserId);

            #endregion

            #region Index

            #endregion
        }
    }
}
