using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SL_FX.Models.Mapping
{
    public class slsoft_ias_dic_t_columnMap : EntityTypeConfiguration<slsoft_ias_dic_t_column>
    {
        public slsoft_ias_dic_t_columnMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CrunodeName)
                .HasMaxLength(128);

            this.Property(t => t.AccessPath)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("slsoft_ias_dic_t_column", "slsoft_iasdb");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CrunodeName).HasColumnName("CrunodeName");
            this.Property(t => t.FatherID).HasColumnName("FatherID");
            this.Property(t => t.AccessPath).HasColumnName("AccessPath");
        }
    }
}
