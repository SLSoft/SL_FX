using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SL_FX.Models.Mapping
{
    public class slsoft_ias_dic_t_hourMap : EntityTypeConfiguration<slsoft_ias_dic_t_hour>
    {
        public slsoft_ias_dic_t_hourMap()
        {
            // Primary Key
            this.HasKey(t => t.hour);

            // Properties
            this.Property(t => t.hour)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("slsoft_ias_dic_t_hour", "slsoft_iasdb");
            this.Property(t => t.hour).HasColumnName("hour");
        }
    }
}
