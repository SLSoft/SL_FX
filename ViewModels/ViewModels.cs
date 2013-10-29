using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using SL_FX.Models;

namespace SL_FX.ViewModels
{
    public class ViewModels
    {

    }

    //
    //------------------注册相关视图-------------------//
    #region
    public class VM_SignUp
    {
        [Required(ErrorMessage = "必须填写用户名")]
        [Display(Name = "用户名")]
        [Remote("CheckLoginName", "Member", ErrorMessage = "该用户名已经被注册了")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "必须填写登陆密码")]
        [Display(Name = "登陆密码")]
        [RegularExpression(@"^[a-zA-Z]\w{5,17}$", ErrorMessage = "密码格式不正确")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "确认密码")]
        [Compare("Password", ErrorMessage = "密码必须一致")]
        [RegularExpression(@"^[a-zA-Z]\w{5,17}$", ErrorMessage = "密码格式不正确")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "姓名")]
        [Required(ErrorMessage = "必须填写姓名")]
        public string NickName { get; set; }
        [Display(Name = "所属单位")]
        [Required(ErrorMessage = "必须填写所属单位")]
        public string CorpName { get; set; }
        [Display(Name = "电子邮箱")]
        [Required(ErrorMessage = "必须填写电子邮箱")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "邮件格式不正确")]
        public string Email { get; set; }
        [Display(Name = "手机号")]
        [Required(ErrorMessage = "必须填写手机号码")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "手机格式不正确")]
        public string Mphone { get; set; }


    }

    public class VM_EditMember
    {
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "必须填写登陆密码")]
        [Display(Name = "登陆密码")]
        [RegularExpression(@"^[a-zA-Z]\w{5,17}$", ErrorMessage = "密码格式不正确")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "确认密码")]
        [Compare("Password", ErrorMessage = "密码必须一致")]
        [RegularExpression(@"^[a-zA-Z]\w{5,17}$", ErrorMessage = "密码格式不正确")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "姓名")]
        [Required(ErrorMessage = "必须填写姓名")]
        public string NickName { get; set; }
        [Display(Name = "所属单位")]
        [Required(ErrorMessage = "必须填写所属单位")]
        public string CorpName { get; set; }
        [Display(Name = "电子邮箱")]
        [Required(ErrorMessage = "必须填写电子邮箱")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "邮件格式不正确")]
        public string Email { get; set; }
        [Display(Name = "手机号")]
        [Required(ErrorMessage = "必须填写手机号码")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "手机格式不正确")]
        public string Mphone { get; set; }


    }

    public class VM_ChangePassword
    {
        [Remote("CheckPassword", "Member", ErrorMessage = "原密码不正确")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "必须填写原密码")]
        [Display(Name = "原密码")]
        [RegularExpression(@"^[a-zA-Z]\w{5,17}$", ErrorMessage = "密码格式不正确")]
        public string OldPassword { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "必须填写新密码")]
        [Display(Name = "新密码")]
        [RegularExpression(@"^[a-zA-Z]\w{5,17}$", ErrorMessage = "密码格式不正确")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "确认密码")]
        [Compare("Password", ErrorMessage = "密码必须一致")]
        [RegularExpression(@"^[a-zA-Z]\w{5,17}$", ErrorMessage = "密码格式不正确")]
        public string ConfirmPassword { get; set; }


    }
    #endregion

    public class VM_UserSite
    {
        public IEnumerable<slsoft_ias_sys_t_user> Users { get; set; }
        public IEnumerable<slsoft_ias_sys_t_userauthorization> mapping { get; set; }
        public IEnumerable<slsoft_ias_sys_t_site> Sites { get; set; }
    }

}