using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SL_FX.Models.Mapping
{
    public class dic_t_provincesMap : EntityTypeConfiguration<dic_t_provinces>
    {
        public dic_t_provincesMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.provinceid)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.province)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dic_t_provinces", "slsoft_iasdb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.provinceid).HasColumnName("provinceid");
            this.Property(t => t.province).HasColumnName("province");
        }
    }
}
