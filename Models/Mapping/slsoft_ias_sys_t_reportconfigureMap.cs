using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SL_FX.Models.Mapping
{
    public class slsoft_ias_sys_t_reportconfigureMap : EntityTypeConfiguration<slsoft_ias_sys_t_reportconfigure>
    {
        public slsoft_ias_sys_t_reportconfigureMap()
        {
            // Primary Key
            this.HasKey(t => t.SiteID);

            // Properties
            this.Property(t => t.SiteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReceiveFrequency)
                .HasMaxLength(50);

            this.Property(t => t.ReceiveType)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("slsoft_ias_sys_t_reportconfigure", "slsoft_iasdb");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.ReceiveFrequency).HasColumnName("ReceiveFrequency");
            this.Property(t => t.ReceiveType).HasColumnName("ReceiveType");
            this.Property(t => t.Email).HasColumnName("Email");
        }
    }
}
