using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SL_FX.Models.Mapping
{
    public class slsoft_ias_bus_t_flowanalysisMap : EntityTypeConfiguration<slsoft_ias_bus_t_flowanalysis>
    {
        public slsoft_ias_bus_t_flowanalysisMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(512);

            this.Property(t => t.StatisticsSite_Code)
                .HasMaxLength(512);

            this.Property(t => t.NewUV)
                .HasMaxLength(256);

            this.Property(t => t.AvgDepthCount)
                .HasMaxLength(256);

            this.Property(t => t.AvgTimeSpent)
                .HasMaxLength(256);

            this.Property(t => t.AvgOut)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("slsoft_ias_bus_t_flowanalysis", "slsoft_iasdb");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.StatisticsSite_ID).HasColumnName("StatisticsSite_ID");
            this.Property(t => t.StatisticsSite_Code).HasColumnName("StatisticsSite_Code");
            this.Property(t => t.TimeZone).HasColumnName("TimeZone");
            this.Property(t => t.StatisticalDate).HasColumnName("StatisticalDate");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.Month).HasColumnName("Month");
            this.Property(t => t.Day).HasColumnName("Day");
            this.Property(t => t.Hour).HasColumnName("Hour");
            this.Property(t => t.Minute).HasColumnName("Minute");
            this.Property(t => t.Second).HasColumnName("Second");
            this.Property(t => t.PV).HasColumnName("PV");
            this.Property(t => t.UV).HasColumnName("UV");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.NewUV).HasColumnName("NewUV");
            this.Property(t => t.Session).HasColumnName("Session");
            this.Property(t => t.PageLength).HasColumnName("PageLength");
            this.Property(t => t.PageOut).HasColumnName("PageOut");
            this.Property(t => t.ThePerCapitaBrowsingPages).HasColumnName("ThePerCapitaBrowsingPages");
            this.Property(t => t.AvgDepthCount).HasColumnName("AvgDepthCount");
            this.Property(t => t.AvgTimeSpent).HasColumnName("AvgTimeSpent");
            this.Property(t => t.AvgOut).HasColumnName("AvgOut");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
        }
    }
}
