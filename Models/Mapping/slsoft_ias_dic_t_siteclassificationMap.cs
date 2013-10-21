using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SL_FX.Models.Mapping
{
    public class slsoft_ias_dic_t_siteclassificationMap : EntityTypeConfiguration<slsoft_ias_dic_t_siteclassification>
    {
        public slsoft_ias_dic_t_siteclassificationMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(512);

            this.Property(t => t.ClassName)
                .HasMaxLength(512);

            this.Property(t => t.SiteClassification_Parent_Code)
                .HasMaxLength(512);

            this.Property(t => t.Remarks)
                .HasMaxLength(512);

            // Table & Column Mappings
            this.ToTable("slsoft_ias_dic_t_siteclassification", "slsoft_iasdb");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.ClassName).HasColumnName("ClassName");
            this.Property(t => t.SiteClassification_Parent_ID).HasColumnName("SiteClassification_Parent_ID");
            this.Property(t => t.SiteClassification_Parent_Code).HasColumnName("SiteClassification_Parent_Code");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.SupervisorStatus).HasColumnName("SupervisorStatus");
            this.Property(t => t.LastEnableTime).HasColumnName("LastEnableTime");
            this.Property(t => t.LastDisableTime).HasColumnName("LastDisableTime");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
        }
    }
}
