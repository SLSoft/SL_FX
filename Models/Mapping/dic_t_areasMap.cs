using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SL_FX.Models.Mapping
{
    public class dic_t_areasMap : EntityTypeConfiguration<dic_t_areas>
    {
        public dic_t_areasMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.areaid)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.area)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.cityid)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("dic_t_areas", "slsoft_iasdb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.areaid).HasColumnName("areaid");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.cityid).HasColumnName("cityid");
        }
    }
}
