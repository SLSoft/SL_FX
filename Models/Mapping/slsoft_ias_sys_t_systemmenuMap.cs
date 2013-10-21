using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SL_FX.Models.Mapping
{
    public class slsoft_ias_sys_t_systemmenuMap : EntityTypeConfiguration<slsoft_ias_sys_t_systemmenu>
    {
        public slsoft_ias_sys_t_systemmenuMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.MenuName)
                .HasMaxLength(200);

            this.Property(t => t.MenuUrl)
                .HasMaxLength(200);

            this.Property(t => t.ExternalLinks)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("slsoft_ias_sys_t_systemmenu", "slsoft_iasdb");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MenuName).HasColumnName("MenuName");
            this.Property(t => t.MenuUrl).HasColumnName("MenuUrl");
            this.Property(t => t.FatherID).HasColumnName("FatherID");
            this.Property(t => t.ExternalLinks).HasColumnName("ExternalLinks");
            this.Property(t => t.SortID).HasColumnName("SortID");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.ModifiyTime).HasColumnName("ModifiyTime");
        }
    }
}
