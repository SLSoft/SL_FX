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

        protected string GetSiteCode(string areaid)
        {
            string SiteCode = "";
            SiteCode = areaid + DateTime.Now.ToString("yyyyMMdd");
            int maxid = db.slsoft_ias_sys_t_site.Max(m => m.SiteID) + 1;
            return SiteCode + maxid.ToString();
        }

        public string GetProvinceName(string provinceid)
        {
            slsoft_iasdbContext db = new slsoft_iasdbContext();
            if (db.dic_t_provinces.Where(d => d.provinceid == provinceid).First() != null)
                return db.dic_t_provinces.Where(d => d.provinceid == provinceid).First().province;
            else
                return "";
        }

        public string GetCityName(string cityid)
        {
            if (db.dic_t_cities.Where(d => d.cityid == cityid).First() != null)
                return db.dic_t_cities.Where(d => d.cityid == cityid).First().city;
            else
                return "";
        }

        public string GetAreaName(string areaid)
        {
            slsoft_iasdbContext db = new slsoft_iasdbContext();
            if (db.dic_t_areas.Where(d => d.areaid == areaid).First() != null)
                return db.dic_t_areas.Where(d => d.areaid == areaid).First().area;
            else
                return "";
        }
    }
}
