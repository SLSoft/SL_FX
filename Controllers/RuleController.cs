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
            //var userlist = db.slsoft_ias_sys_t_user.Where(u => u.ParentUserID == CurrentUser().UserID).ToList();
            //ViewModels.VM_UserSite viewmodel = new VM_UserSite();
            //viewmodel.Users = db.slsoft_ias_sys_t_user.Include(
            return View();
        }

    }
}
