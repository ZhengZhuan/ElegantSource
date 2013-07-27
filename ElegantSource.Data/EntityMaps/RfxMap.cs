using System.Data.Entity.ModelConfiguration;
using ElegantSource.Entity.Entities;

namespace ElegantSource.Data.EntityMaps
{
    public class RfxMap:EntityTypeConfiguration<Rfx>
    {
        public RfxMap()
        {
            HasKey(r => r.Id);
            Property(r => r.Name).IsRequired().HasMaxLength(50);
        }
    }
}
