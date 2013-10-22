using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SL_FX.Models;

namespace SL_FX.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Base/
        public SL_FX.Models.slsoft_iasdbContext db = new slsoft_iasdbContext();

        public ActionResult Index()
        {
            return View();
        }

        protected slsoft_ias_sys_t_user CurrentUser()
        {
            Session["UserID"] = "5";    //供测试使用，正式删除
            if (Session["UserID"] != null && Session["UserID"].ToString() != "")
            {
                var member = db.slsoft_ias_sys_t_user.Find(Convert.ToInt32(Session["UserID"].ToString()));
                return member;
            }
            return null;
        }

    }
}
