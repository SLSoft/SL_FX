using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SL_FX.Models.Mapping
{
    public class slsoft_ias_dic_t_column_clickMap : EntityTypeConfiguration<slsoft_ias_dic_t_column_click>
    {
        public slsoft_ias_dic_t_column_clickMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.cname)
                .HasMaxLength(128);

            this.Property(t => t.CreateTime)
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("slsoft_ias_dic_t_column_click", "slsoft_iasdb");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.cid).HasColumnName("cid");
            this.Property(t => t.cname).HasColumnName("cname");
            this.Property(t => t.fid).HasColumnName("fid");
            this.Property(t => t.pvnum).HasColumnName("pvnum");
            this.Property(t => t.uvnum).HasColumnName("uvnum");
            this.Property(t => t.ipnum).HasColumnName("ipnum");
            this.Property(t => t.lennum).HasColumnName("lennum");
            this.Property(t => t.unum).HasColumnName("unum");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
