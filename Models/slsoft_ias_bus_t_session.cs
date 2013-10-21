using System;
using System.Collections.Generic;

namespace SL_FX.Models
{
    public class slsoft_ias_bus_t_session
    {
        public string Code { get; set; }
        public string UserCode { get; set; }
        public Nullable<int> StatisticsSite_ID { get; set; }
        public string StatisticsSite_Code { get; set; }
        public Nullable<int> SourceClass_ID { get; set; }
        public string SourceClass_Code { get; set; }
        public string SourcePath { get; set; }
        public string SourceKey { get; set; }
        public string LastAccessPage { get; set; }
        public Nullable<int> LengthOfSession { get; set; }
        public Nullable<int> SessionDepth { get; set; }
        public Nullable<int> TimeZone { get; set; }
        public Nullable<System.DateTime> AccessDate { get; set; }
        public Nullable<int> IsUV { get; set; }
        public Nullable<int> IsNewUV { get; set; }
        public Nullable<System.DateTime> LastBrowsingTime { get; set; }
        public Nullable<int> NumberOfVisits { get; set; }
        public string NetworkAccessProvider { get; set; }
        public string Language { get; set; }
        public string DeviceType { get; set; }
        public string AboutDevice { get; set; }
        public string OperationSystem { get; set; }
        public string Resolution { get; set; }
        public string Color { get; set; }
        public string UserAgent { get; set; }
        public string UserAgentMD5 { get; set; }
        public string Browser { get; set; }
        public string BrowserEdition { get; set; }
        public string BrowserKernel { get; set; }
        public Nullable<int> IsCookieSupport { get; set; }
        public Nullable<int> IsJavaSupport { get; set; }
        public Nullable<int> IsFrameWebpageSupport { get; set; }
        public string Plugin { get; set; }
        public string ClientIP { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string ServerIP { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> IsValid { get; set; }
    }
}
