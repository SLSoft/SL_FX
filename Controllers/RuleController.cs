using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SL_FX.Models;
using SL_FX.ViewModels;

namespace SL_FX.Controllers
{
    public class RuleController : BaseController
    {
        //
        // GET: /Rule/

        public ActionResult Index()
        {
            var users = db.slsoft_ias_sys_t_user.Where(u => u.ParentUserID == 1).ToList();
            foreach (var user in users)
            {
                user.usersites = db.slsoft_ias_sys_t_userauthorization.Where(u => u.UserID == user.UserID).ToList();
            }
            return View(users);
        }


        public ActionResult Add()
        {
            BindSiteList();
            VM_SignUp user = new VM_SignUp();
            return View(user);
        }

        [HttpPost]
        public ActionResult Add(VM_SignUp user, FormCollection fc)
        {
            BindSiteList();
            try
            {
                ModelState.Remove("Password");
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var userInfo = new slsoft_ias_sys_t_user();
                    userInfo.UserName = user.UserName;          //用户名
                    userInfo.Password = "111111";          //密码
                    userInfo.NickName = user.NickName;          //姓名
                    userInfo.Email = user.Email;                //电子邮箱
                    userInfo.CorpName = user.CorpName;          //企业名称
                    userInfo.Mphone = user.Mphone;              //手机号

                    userInfo.UserLevel = "1";                    //用户级别
                    userInfo.UserState = "0";                  //用户状态
                    userInfo.ParentUserID = CurrentUser().UserID;                  //创建人
                    userInfo.IsValid = true;                    //有效标志
                    userInfo.CreateTime = DateTime.Now;         //创建时间
                    userInfo.ModifiyTime = DateTime.Now;        //修改时间

                    db.slsoft_ias_sys_t_user.Add(userInfo);
                    db.SaveChanges();

                    var insertuser = db.slsoft_ias_sys_t_user.Where(u => u.UserName == userInfo.UserName).FirstOrDefault();
                    //保存授权信息
                    var rule = new slsoft_ias_sys_t_userauthorization();
                    string [] arr = fc["SiteList"].ToString().Split(',');
                    foreach (string siteid in arr)
                    {
                        rule.UserID = insertuser.UserID;
                        rule.SiteID = Convert.ToInt32(siteid);
                        db.slsoft_ias_sys_t_userauthorization.Add(rule);
                        db.SaveChanges();
                    }
                    
                }

                return RedirectToAction("Index");
            }
            catch(Exception exp)
            {
                return View();
            }
        }

        public void BindSiteList()
        {
            var sites = db.slsoft_ias_sys_t_site.Where(s => s.SiteAdmin == "0").ToList();

            ViewData["SiteList"] = new SelectList(sites, "siteid", "sitename");
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                if (Request.IsAjaxRequest())
                {
                    var u_site = db.slsoft_ias_sys_t_userauthorization.Where(a => a.UserID == id).ToList();
                    foreach (slsoft_ias_sys_t_userauthorization site in u_site)
                    {
                        db.slsoft_ias_sys_t_userauthorization.Remove(site);
                        db.SaveChanges();
                    }
                    return RedirectToAction("Index");
                }
                else
                {
                    return Content("-1");
                }
            }
            catch
            {
                return Content("-1");
            }
        }
    }
}
