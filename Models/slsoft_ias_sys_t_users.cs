using System;
using System.Collections.Generic;

namespace SL_FX.Models
{
    public class slsoft_ias_sys_t_users
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string OrganizationName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<int> EmailAddressIsValid { get; set; }
        public Nullable<int> UserRole { get; set; }
        public string ContactsName { get; set; }
        public string WorkUnit { get; set; }
        public string MobilePhone { get; set; }
        public Nullable<int> MobilePhoneIsValid { get; set; }
        public string LandlineTelephone { get; set; }
        public string QQ { get; set; }
        public string MSN { get; set; }
        public Nullable<System.DateTime> RegistrationTime { get; set; }
        public Nullable<System.DateTime> FirstActivationTime { get; set; }
        public Nullable<System.DateTime> LastEnableTime { get; set; }
        public Nullable<System.DateTime> LastDisableTime { get; set; }
        public Nullable<int> UserStatus { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string LastLoginIP { get; set; }
        public Nullable<System.DateTime> LastLoginTime { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> IsValid { get; set; }
    }
}
