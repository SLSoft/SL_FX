using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SL_FX.Models.Mapping
{
    public class slsoft_ias_sys_t_userMap : EntityTypeConfiguration<slsoft_ias_sys_t_user>
    {
        public slsoft_ias_sys_t_userMap()
        {
            // Primary Key
            this.HasKey(t => t.UserID);

            // Properties
            this.Property(t => t.UserName)
                .HasMaxLength(200);

            this.Property(t => t.Password)
                .HasMaxLength(100);

            this.Property(t => t.NickName)
                .HasMaxLength(200);

            this.Property(t => t.CorpName)
                .HasMaxLength(200);

            this.Property(t => t.Email)
                .HasMaxLength(100);

            this.Property(t => t.Mphone)
                .HasMaxLength(100);

            this.Property(t => t.UserLevel)
                .HasMaxLength(50);

            this.Property(t => t.UserState)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("slsoft_ias_sys_t_user", "slsoft_iasdb");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.NickName).HasColumnName("NickName");
            this.Property(t => t.CorpName).HasColumnName("CorpName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Mphone).HasColumnName("Mphone");
            this.Property(t => t.UserLevel).HasColumnName("UserLevel");
            this.Property(t => t.UserState).HasColumnName("UserState");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.ModifiyTime).HasColumnName("ModifiyTime");
        }
    }
}
