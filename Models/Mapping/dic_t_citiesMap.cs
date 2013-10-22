using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SL_FX.Models.Mapping
{
    public class dic_t_citiesMap : EntityTypeConfiguration<dic_t_cities>
    {
        public dic_t_citiesMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.cityid)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.city)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.provinceid)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("dic_t_cities", "slsoft_iasdb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.cityid).HasColumnName("cityid");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.provinceid).HasColumnName("provinceid");
        }
    }
}
