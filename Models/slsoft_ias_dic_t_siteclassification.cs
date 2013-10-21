using System;
using System.Collections.Generic;

namespace SL_FX.Models
{
    public class slsoft_ias_dic_t_siteclassification
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string ClassName { get; set; }
        public Nullable<int> SiteClassification_Parent_ID { get; set; }
        public string SiteClassification_Parent_Code { get; set; }
        public Nullable<int> OrderID { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> SupervisorStatus { get; set; }
        public Nullable<System.DateTime> LastEnableTime { get; set; }
        public Nullable<System.DateTime> LastDisableTime { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> IsValid { get; set; }
    }
}
