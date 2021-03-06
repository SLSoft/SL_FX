using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SL_FX.Models
{
    public class slsoft_ias_sys_t_site
    {
        public int SiteID { get; set; }
        public string SiteCode { get; set; }
        [Required(ErrorMessage = "������дվ������")]
        public string SiteName { get; set; }
        [Required(ErrorMessage = "������дվ������")]
        public string DomainName { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string SiteType { get; set; }
        public string SiteAdmin { get; set; }
        public string RunningState { get; set; }
        public Nullable<bool> IsValid { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> ModifiyTime { get; set; }
        public string AuditState { get; set; }

        public string AreaName;
    }
}
