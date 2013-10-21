using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SL_FX.Models.Mapping
{
    public class slsoft_ias_sys_t_usersMap : EntityTypeConfiguration<slsoft_ias_sys_t_users>
    {
        public slsoft_ias_sys_t_usersMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(512);

            this.Property(t => t.OrganizationName)
                .HasMaxLength(512);

            this.Property(t => t.UserName)
                .HasMaxLength(512);

            this.Property(t => t.Password)
                .HasMaxLength(512);

            this.Property(t => t.EmailAddress)
                .HasMaxLength(256);

            this.Property(t => t.ContactsName)
                .HasMaxLength(256);

            this.Property(t => t.WorkUnit)
                .HasMaxLength(256);

            this.Property(t => t.MobilePhone)
                .HasMaxLength(256);

            this.Property(t => t.LandlineTelephone)
                .HasMaxLength(256);

            this.Property(t => t.QQ)
                .HasMaxLength(64);

            this.Property(t => t.MSN)
                .HasMaxLength(256);

            this.Property(t => t.Country)
                .HasMaxLength(64);

            this.Property(t => t.Province)
                .HasMaxLength(64);

            this.Property(t => t.City)
                .HasMaxLength(64);

            this.Property(t => t.LastLoginIP)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("slsoft_ias_sys_t_users", "slsoft_iasdb");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.OrganizationName).HasColumnName("OrganizationName");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.EmailAddress).HasColumnName("EmailAddress");
            this.Property(t => t.EmailAddressIsValid).HasColumnName("EmailAddressIsValid");
            this.Property(t => t.UserRole).HasColumnName("UserRole");
            this.Property(t => t.ContactsName).HasColumnName("ContactsName");
            this.Property(t => t.WorkUnit).HasColumnName("WorkUnit");
            this.Property(t => t.MobilePhone).HasColumnName("MobilePhone");
            this.Property(t => t.MobilePhoneIsValid).HasColumnName("MobilePhoneIsValid");
            this.Property(t => t.LandlineTelephone).HasColumnName("LandlineTelephone");
            this.Property(t => t.QQ).HasColumnName("QQ");
            this.Property(t => t.MSN).HasColumnName("MSN");
            this.Property(t => t.RegistrationTime).HasColumnName("RegistrationTime");
            this.Property(t => t.FirstActivationTime).HasColumnName("FirstActivationTime");
            this.Property(t => t.LastEnableTime).HasColumnName("LastEnableTime");
            this.Property(t => t.LastDisableTime).HasColumnName("LastDisableTime");
            this.Property(t => t.UserStatus).HasColumnName("UserStatus");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Province).HasColumnName("Province");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.LastLoginIP).HasColumnName("LastLoginIP");
            this.Property(t => t.LastLoginTime).HasColumnName("LastLoginTime");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
        }
    }
}
