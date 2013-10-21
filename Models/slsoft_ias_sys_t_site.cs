using System;
using System.Collections.Generic;

namespace SL_FX.Models
{
    public class slsoft_ias_sys_t_site
    {
        public int SiteID { get; set; }
        public string SiteCode { get; set; }
        public string SiteName { get; set; }
        public string DomainName { get; set; }
        public Nullable<int> Province { get; set; }
        public Nullable<int> City { get; set; }
        public Nullable<int> Area { get; set; }
        public string SiteType { get; set; }
        public string SiteAdmin { get; set; }
        public string RunningState { get; set; }
        public Nullable<bool> IsValid { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> ModifiyTime { get; set; }
        public string AuditState { get; set; }
    }
}
