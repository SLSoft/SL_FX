using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SL_FX.Models.Mapping
{
    public class slsoft_ias_sys_t_siteMap : EntityTypeConfiguration<slsoft_ias_sys_t_site>
    {
        public slsoft_ias_sys_t_siteMap()
        {
            // Primary Key
            this.HasKey(t => t.SiteID);

            // Properties
            this.Property(t => t.SiteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SiteCode)
                .HasMaxLength(200);

            this.Property(t => t.SiteName)
                .HasMaxLength(200);

            this.Property(t => t.DomainName)
                .HasMaxLength(200);

            this.Property(t => t.Province)
                .HasMaxLength(20);

            this.Property(t => t.City)
                .HasMaxLength(20);

            this.Property(t => t.Area)
                .HasMaxLength(20);

            this.Property(t => t.SiteType)
                .HasMaxLength(200);

            this.Property(t => t.SiteAdmin)
                .HasMaxLength(50);

            this.Property(t => t.RunningState)
                .HasMaxLength(50);

            this.Property(t => t.AuditState)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("slsoft_ias_sys_t_site", "slsoft_iasdb");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.SiteCode).HasColumnName("SiteCode");
            this.Property(t => t.SiteName).HasColumnName("SiteName");
            this.Property(t => t.DomainName).HasColumnName("DomainName");
            this.Property(t => t.Province).HasColumnName("Province");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.SiteType).HasColumnName("SiteType");
            this.Property(t => t.SiteAdmin).HasColumnName("SiteAdmin");
            this.Property(t => t.RunningState).HasColumnName("RunningState");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.ModifiyTime).HasColumnName("ModifiyTime");
            this.Property(t => t.AuditState).HasColumnName("AuditState");
        }
    }
}
