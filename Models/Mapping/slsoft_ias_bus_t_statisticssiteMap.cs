using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SL_FX.Models.Mapping
{
    public class slsoft_ias_bus_t_statisticssiteMap : EntityTypeConfiguration<slsoft_ias_bus_t_statisticssite>
    {
        public slsoft_ias_bus_t_statisticssiteMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(512);

            this.Property(t => t.Users_Code)
                .HasMaxLength(512);

            this.Property(t => t.StatisticsSiteName)
                .HasMaxLength(256);

            this.Property(t => t.StatisticsRange)
                .HasMaxLength(2048);

            this.Property(t => t.HomePage)
                .HasMaxLength(512);

            this.Property(t => t.Remarks)
                .HasMaxLength(512);

            // Table & Column Mappings
            this.ToTable("slsoft_ias_bus_t_statisticssite", "slsoft_iasdb");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Users_ID).HasColumnName("Users_ID");
            this.Property(t => t.Users_Code).HasColumnName("Users_Code");
            this.Property(t => t.StatisticsSiteName).HasColumnName("StatisticsSiteName");
            this.Property(t => t.StatisticsRange).HasColumnName("StatisticsRange");
            this.Property(t => t.HomePage).HasColumnName("HomePage");
            this.Property(t => t.SiteClassification_ClassA_Code).HasColumnName("SiteClassification_ClassA_Code");
            this.Property(t => t.SiteClassification_ClassA_ID).HasColumnName("SiteClassification_ClassA_ID");
            this.Property(t => t.SiteClassification_ClassB_Code).HasColumnName("SiteClassification_ClassB_Code");
            this.Property(t => t.SiteClassification_ClassB_ID).HasColumnName("SiteClassification_ClassB_ID");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.SupervisorStatus).HasColumnName("SupervisorStatus");
            this.Property(t => t.LastEnableTime).HasColumnName("LastEnableTime");
            this.Property(t => t.LastDisableTime).HasColumnName("LastDisableTime");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
        }
    }
}
