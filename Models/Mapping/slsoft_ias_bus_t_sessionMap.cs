using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SL_FX.Models.Mapping
{
    public class slsoft_ias_bus_t_sessionMap : EntityTypeConfiguration<slsoft_ias_bus_t_session>
    {
        public slsoft_ias_bus_t_sessionMap()
        {
            // Primary Key
            this.HasKey(t => t.Code);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.UserCode)
                .HasMaxLength(128);

            this.Property(t => t.StatisticsSite_Code)
                .HasMaxLength(512);

            this.Property(t => t.SourceClass_Code)
                .HasMaxLength(512);

            this.Property(t => t.SourcePath)
                .HasMaxLength(512);

            this.Property(t => t.SourceKey)
                .HasMaxLength(512);

            this.Property(t => t.LastAccessPage)
                .HasMaxLength(512);

            this.Property(t => t.NetworkAccessProvider)
                .HasMaxLength(128);

            this.Property(t => t.Language)
                .HasMaxLength(32);

            this.Property(t => t.DeviceType)
                .HasMaxLength(64);

            this.Property(t => t.AboutDevice)
                .HasMaxLength(64);

            this.Property(t => t.OperationSystem)
                .HasMaxLength(64);

            this.Property(t => t.Resolution)
                .HasMaxLength(32);

            this.Property(t => t.Color)
                .HasMaxLength(32);

            this.Property(t => t.UserAgent)
                .HasMaxLength(256);

            this.Property(t => t.UserAgentMD5)
                .HasMaxLength(256);

            this.Property(t => t.Browser)
                .HasMaxLength(32);

            this.Property(t => t.BrowserEdition)
                .HasMaxLength(32);

            this.Property(t => t.BrowserKernel)
                .HasMaxLength(512);

            this.Property(t => t.Plugin)
                .HasMaxLength(1024);

            this.Property(t => t.ClientIP)
                .HasMaxLength(256);

            this.Property(t => t.Country)
                .HasMaxLength(64);

            this.Property(t => t.Province)
                .HasMaxLength(64);

            this.Property(t => t.City)
                .HasMaxLength(64);

            this.Property(t => t.Area)
                .HasMaxLength(64);

            this.Property(t => t.ServerIP)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("slsoft_ias_bus_t_session", "slsoft_iasdb");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.StatisticsSite_ID).HasColumnName("StatisticsSite_ID");
            this.Property(t => t.StatisticsSite_Code).HasColumnName("StatisticsSite_Code");
            this.Property(t => t.SourceClass_ID).HasColumnName("SourceClass_ID");
            this.Property(t => t.SourceClass_Code).HasColumnName("SourceClass_Code");
            this.Property(t => t.SourcePath).HasColumnName("SourcePath");
            this.Property(t => t.SourceKey).HasColumnName("SourceKey");
            this.Property(t => t.LastAccessPage).HasColumnName("LastAccessPage");
            this.Property(t => t.LengthOfSession).HasColumnName("LengthOfSession");
            this.Property(t => t.SessionDepth).HasColumnName("SessionDepth");
            this.Property(t => t.TimeZone).HasColumnName("TimeZone");
            this.Property(t => t.AccessDate).HasColumnName("AccessDate");
            this.Property(t => t.IsUV).HasColumnName("IsUV");
            this.Property(t => t.IsNewUV).HasColumnName("IsNewUV");
            this.Property(t => t.LastBrowsingTime).HasColumnName("LastBrowsingTime");
            this.Property(t => t.NumberOfVisits).HasColumnName("NumberOfVisits");
            this.Property(t => t.NetworkAccessProvider).HasColumnName("NetworkAccessProvider");
            this.Property(t => t.Language).HasColumnName("Language");
            this.Property(t => t.DeviceType).HasColumnName("DeviceType");
            this.Property(t => t.AboutDevice).HasColumnName("AboutDevice");
            this.Property(t => t.OperationSystem).HasColumnName("OperationSystem");
            this.Property(t => t.Resolution).HasColumnName("Resolution");
            this.Property(t => t.Color).HasColumnName("Color");
            this.Property(t => t.UserAgent).HasColumnName("UserAgent");
            this.Property(t => t.UserAgentMD5).HasColumnName("UserAgentMD5");
            this.Property(t => t.Browser).HasColumnName("Browser");
            this.Property(t => t.BrowserEdition).HasColumnName("BrowserEdition");
            this.Property(t => t.BrowserKernel).HasColumnName("BrowserKernel");
            this.Property(t => t.IsCookieSupport).HasColumnName("IsCookieSupport");
            this.Property(t => t.IsJavaSupport).HasColumnName("IsJavaSupport");
            this.Property(t => t.IsFrameWebpageSupport).HasColumnName("IsFrameWebpageSupport");
            this.Property(t => t.Plugin).HasColumnName("Plugin");
            this.Property(t => t.ClientIP).HasColumnName("ClientIP");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Province).HasColumnName("Province");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.ServerIP).HasColumnName("ServerIP");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
        }
    }
}
