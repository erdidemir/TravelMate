using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Domain.Entities.Commons;

namespace TravelMate.Domain.Configurations.Commons
{
    public abstract class EntityTypeConfigurationBase<T> : IEntityTypeConfiguration<T> where T : EntityBase
    {
        public virtual void Configure(EntityTypeBuilder<T> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.CreatedDate).IsRequired();
            entity.Property(e => e.IsActive).IsRequired();
            entity.Property(e => e.DisplayOrder).IsRequired();
        }
    }
}
