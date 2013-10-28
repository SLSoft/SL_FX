using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SL_FX.Models;

namespace SL_FX.Controllers
{
    public class WebSiteController : BaseController
    {
        //
        // GET: /WebSite/

        public ViewResult Index()
        {
            var t_site = db.slsoft_ias_sys_t_site.Where(s => s.IsValid == true).ToList();
            foreach (var site in t_site)
            {
                site.AreaName = GetProvinceName(site.Province) + GetCityName(site.City) + GetAreaName(site.Area);
            }
            return View(t_site);
        }

        public ActionResult Create()
        {
            List<SelectListItem> SiteType = new List<SelectListItem>
            {
              new SelectListItem { Text = "政府门户", Value = "政府门户" }
            };
            ViewData["SiteType"] = SiteType;
            BindProperty();
            return View();
        } 

        [HttpPost]
        public ActionResult Create(slsoft_ias_sys_t_site t_site, FormCollection fc)
        {
            if (ModelState.IsValid)
            {
                string areaid = "";
                if (t_site.Province!=null)
                    areaid = t_site.Province;
                if (fc["ddlCity"] != null)
                    areaid = fc["ddlCity"].ToString();
                if (fc["ddlArea"] != null)
                    areaid = fc["ddlArea"].ToString();
                t_site.SiteCode = GetSiteCode(areaid);
                t_site.City = fc["ddlCity"] == null ? "" : fc["ddlCity"].ToString();
                t_site.Area = fc["ddlArea"] == null ? "" : fc["ddlArea"].ToString();
                t_site.SiteAdmin = "0";
                t_site.RunningState = "1";
                t_site.IsValid = true;
                t_site.CreateTime = DateTime.Now;
                t_site.ModifiyTime = DateTime.Now;
                t_site.AuditState = "";
                db.slsoft_ias_sys_t_site.Add(t_site);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(t_site);
        }

        //
        // POST: /WebSite/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                if (Request.IsAjaxRequest())
                {
                    slsoft_ias_sys_t_site t_site = db.slsoft_ias_sys_t_site.Find(id);
                    t_site.IsValid = false;
                    db.SaveChanges();
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

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        //代码管理
        public ViewResult Code(object select = null)
        {
            var sites = db.slsoft_ias_sys_t_site.Where(s => s.SiteAdmin == "0").ToList();

            ViewData["SiteList"] = new SelectList(sites, "sitecode", "sitename", select);
            return View();
        }

        public void BindProperty(object select = null)
        {
            List<dic_t_provinces> Property = db.dic_t_provinces.ToList();

            ViewData["Province"] = new SelectList(Property, "provinceid", "province", select);
        }
        public JsonResult GetCity(string ParentCode)
        {
            List<dic_t_cities> City = db.dic_t_cities.Where(c => (c.provinceid == ParentCode)).ToList();

            return Json(City, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetArea(string ParentCode)
        {
            List<dic_t_areas> Area = db.dic_t_areas.Where(c => (c.cityid == ParentCode)).ToList();

            return Json(Area, JsonRequestBehavior.AllowGet);
        }

        public ViewResult Query()
        {
            var t_site = db.slsoft_ias_sys_t_site.Where(s => s.IsValid == true).ToList();
            foreach (var site in t_site)
            {
                site.AreaName = GetProvinceName(site.Province) + GetCityName(site.City) + GetAreaName(site.Area);
            }
            return View(t_site);
        }
    }
}