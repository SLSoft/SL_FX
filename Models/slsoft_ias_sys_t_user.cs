using System;
using System.Collections.Generic;

namespace SL_FX.Models
{
    public class slsoft_ias_sys_t_user
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }
        public string CorpName { get; set; }
        public string Email { get; set; }
        public string Mphone { get; set; }
        public string UserLevel { get; set; }
        public string UserState { get; set; }
        public Nullable<bool> IsValid { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> ModifiyTime { get; set; }
    }
}
