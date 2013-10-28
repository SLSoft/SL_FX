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
        [Required(ErrorMessage = "������д�û���")]
        [Display(Name = "�û���")]
        [Remote("CheckLoginName", "Member", ErrorMessage = "���û����Ѿ���ע����")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "����")]
        public string Password { get; set; }

        [Display(Name = "����")]
        public string NickName { get; set; }
        [Display(Name = "������λ")]
        public string CorpName { get; set; }
        [Display(Name = "��������")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "�ʼ���ʽ����ȷ")]
        public string Email { get; set; }
        [Display(Name = "�ֻ���")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "�ֻ���ʽ����ȷ")]
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
