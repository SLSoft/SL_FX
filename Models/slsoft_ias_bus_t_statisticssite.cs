using System;
using System.Collections.Generic;

namespace SL_FX.Models
{
    public class slsoft_ias_bus_t_statisticssite
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public Nullable<int> Users_ID { get; set; }
        public string Users_Code { get; set; }
        public string StatisticsSiteName { get; set; }
        public string StatisticsRange { get; set; }
        public string HomePage { get; set; }
        public Nullable<int> SiteClassification_ClassA_Code { get; set; }
        public Nullable<int> SiteClassification_ClassA_ID { get; set; }
        public Nullable<int> SiteClassification_ClassB_Code { get; set; }
        public Nullable<int> SiteClassification_ClassB_ID { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> SupervisorStatus { get; set; }
        public Nullable<System.DateTime> LastEnableTime { get; set; }
        public Nullable<System.DateTime> LastDisableTime { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> IsValid { get; set; }
    }
}
