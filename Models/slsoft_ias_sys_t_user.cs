using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SL_FX.Models
{
    public class slsoft_ias_sys_t_user
    {
        public slsoft_ias_sys_t_user()
        {
            IsValid = true;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [Required(ErrorMessage = "必须填写用户名")]
        [Display(Name = "用户名")]
        [Remote("CheckLoginName", "Member", ErrorMessage = "该用户名已经被注册了")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [Display(Name = "姓名")]
        public string NickName { get; set; }
        [Display(Name = "所属单位")]
        public string CorpName { get; set; }
        [Display(Name = "电子邮箱")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "邮件格式不正确")]
        public string Email { get; set; }
        [Display(Name = "手机号")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "手机格式不正确")]
        public string Mphone { get; set; }
        public string UserLevel { get; set; }
        public string UserState { get; set; }
        public int ParentUserID { get; set; }
        public Nullable<bool> IsValid { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> ModifiyTime { get; set; }

        public virtual ICollection<slsoft_ias_sys_t_userauthorization> usersites { get; set; }
    }
}
