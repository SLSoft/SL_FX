using System;
using System.Collections.Generic;

namespace SL_FX.Models
{
    public class slsoft_ias_bus_t_flowanalysis
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public Nullable<int> StatisticsSite_ID { get; set; }
        public string StatisticsSite_Code { get; set; }
        public Nullable<int> TimeZone { get; set; }
        public Nullable<System.DateTime> StatisticalDate { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Day { get; set; }
        public Nullable<int> Hour { get; set; }
        public Nullable<int> Minute { get; set; }
        public Nullable<int> Second { get; set; }
        public Nullable<int> PV { get; set; }
        public Nullable<int> UV { get; set; }
        public Nullable<int> IP { get; set; }
        public string NewUV { get; set; }
        public Nullable<int> Session { get; set; }
        public Nullable<int> ThePerCapitaBrowsingPages { get; set; }
        public string AvgDepthCount { get; set; }
        public string AvgTimeSpent { get; set; }
        public string AvgOut { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> IsValid { get; set; }
    }
}
