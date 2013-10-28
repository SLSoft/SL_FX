using System;
using System.Collections.Generic;

namespace SL_FX.Models
{
    public class slsoft_ias_sys_t_userauthorization
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> SiteID { get; set; }

        public string SiteName
        {
            get
            {
                slsoft_iasdbContext db = new slsoft_iasdbContext();
                if (db.slsoft_ias_sys_t_site.Find(this.SiteID) != null)
                    return db.slsoft_ias_sys_t_site.Find(this.SiteID).SiteName;
                else
                    return "";
            }
        }
    }
}
