using System;
using System.Collections.Generic;

namespace SL_FX.Models
{
    public class slsoft_ias_sys_t_systemmenu
    {
        public int ID { get; set; }
        public string MenuName { get; set; }
        public string MenuUrl { get; set; }
        public Nullable<int> FatherID { get; set; }
        public string ExternalLinks { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<bool> IsValid { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> ModifiyTime { get; set; }
    }
}
