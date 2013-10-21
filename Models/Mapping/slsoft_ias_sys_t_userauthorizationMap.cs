using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SL_FX.Models.Mapping
{
    public class slsoft_ias_sys_t_userauthorizationMap : EntityTypeConfiguration<slsoft_ias_sys_t_userauthorization>
    {
        public slsoft_ias_sys_t_userauthorizationMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("slsoft_ias_sys_t_userauthorization", "slsoft_iasdb");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
        }
    }
}
