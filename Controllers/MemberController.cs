using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SL_FX.Models;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using SL_FX.ViewModels;
using System.Data;

namespace SL_FX.Controllers
{
    public class MemberController : BaseController
    {
        //
        // GET: /Member/

        public ActionResult Index()
        {
            return View();
        }




        //
        // GET: /Member/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }


        public ActionResult ChangePassword()
        {
            return View();
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="fc"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ChangePassword(FormCollection fc, VM_ChangePassword cp)
        {
            try
            {
                // TODO: Add update logic here
                var member = CurrentUser();
                if (member != null)
                {
                    if (fc["OldPassword"] != member.Password)
                    {
                        return View(cp);
                    }

                    db.Entry(member).State = EntityState.Modified;

                    member.Password = fc["Password"];          //密码


                    member.ModifiyTime = DateTime.Now;                  //修改时间

                    db.SaveChanges();


                }
                return PartialView();
                //return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }


        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            try
            {
                if (fc["verify"] != Session["ValidateCode"].ToString())
                {

                    return View();
                }
                string strUserName = fc["Username"];
                slsoft_ias_sys_t_user member = db.slsoft_ias_sys_t_user.Where(m => m.UserName == strUserName).First();
                if (member != null && member.Password == fc["password"]&& member.IsValid==true)
                {
                    Session["UserID"] = member.UserID;
                    Session["UserName"] = member.NickName;
                    ViewBag.member = member;

                    //RegisterLoginInfo();

                    if (Session["RedirectUrl"] != null && Session["RedirectUrl"].ToString() != "")
                    {
                        return Redirect(Session["RedirectUrl"].ToString());
                    }
                    return RedirectToAction("Index", "WebSite");
                }
                else
                {
                    ViewData["error"] = "密码错误，请检查后重新尝试!";
                    return View();
                }
            }
            catch
            {
                ViewData["error"] = "登陆名错误，请检查后重新尝试!";
                return View();
            }


        }



        //
        // GET: /Member/Create

        public ActionResult Create()
        {
            VM_SignUp user = new VM_SignUp();
            return View(user);
        }

        //
        // POST: /Member/Create

        [HttpPost]
        public ActionResult Create(VM_SignUp user, FormCollection fc)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    if (fc["verify"] != Session["ValidateCode"].ToString())
                    {

                        return View(user);
                    }

                    var userInfo = new slsoft_ias_sys_t_user();
                    userInfo.UserName = user.UserName;          //用户名
                    userInfo.Password = user.Password;          //密码
                    userInfo.NickName = user.NickName;          //姓名
                    userInfo.Email = user.Email;                //电子邮箱
                    userInfo.CorpName = user.CorpName;          //企业名称
                    userInfo.Mphone = user.Mphone;              //手机号

                    userInfo.UserLevel = "0";                    //用户级别
                    userInfo.UserState = "0";                  //用户状态
                    userInfo.IsValid = true;                    //有效标志
                    userInfo.CreateTime = DateTime.Now;         //创建时间
                    userInfo.ModifiyTime = DateTime.Now;        //修改时间

                    db.slsoft_ias_sys_t_user.Add(userInfo);
                    db.SaveChanges();

                }

                slsoft_ias_sys_t_user member = db.slsoft_ias_sys_t_user.Where(m => m.UserName == user.UserName).First();
                if (member != null)
                {
                    Session["UserID"] = member.UserID;
                    Session["UserName"] = member.UserName;
                    ViewBag.member = member;

                    //RegisterLoginInfo();

                    if (Session["RedirectUrl"] != null && Session["RedirectUrl"].ToString() != "")
                    {
                        return Redirect(Session["RedirectUrl"].ToString());
                    }
                    return RedirectToAction("Index", "WebSite");
                }
                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Member/Edit/5

        public ActionResult Edit()
        {
            var member = CurrentUser();
            if (member != null)
            {
                VM_EditMember userInfo = new VM_EditMember();

                userInfo.UserName = member.UserName;          //用户名
                userInfo.Password = member.Password;          //密码
                userInfo.ConfirmPassword = member.Password;   //
                userInfo.NickName = member.NickName;          //姓名
                userInfo.Email = member.Email;                //电子邮箱
                userInfo.CorpName = member.CorpName;          //企业名称
                userInfo.Mphone = member.Mphone;              //手机号
                return PartialView(userInfo);
            }
            return PartialView();

        }

        //
        // POST: /Member/Edit/5

        [HttpPost]
        public ActionResult Edit(FormCollection collection, VM_EditMember vm_edit_member)
        {
            try
            {
                // TODO: Add update logic here
                var member = CurrentUser();
                if (member != null)
                {
                    db.Entry(member).State = EntityState.Modified;


                    member.NickName = vm_edit_member.NickName;          //姓名

                    member.CorpName = vm_edit_member.CorpName;          //企业名称

                    member.ModifiyTime = DateTime.Now;                  //修改时间

                    db.SaveChanges();

                    vm_edit_member.UserName = member.UserName;          //用户名
                    vm_edit_member.Password = member.Password;          //密码
                    vm_edit_member.Email = member.Email;                //电子邮箱
                    vm_edit_member.Mphone = member.Mphone;              //手机号

                }
                return View(vm_edit_member);
                //return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Member/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Member/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult GetValidateCode()
        {
            //ValidateCode vCode = new ValidateCode();
            string code = CreateValidateCode(4);
            Session["ValidateCode"] = code;
            byte[] bytes = CreateValidateGraphic(code);
            return File(bytes, @"image/jpeg");
        }

        //验证
        public JsonResult CheckLoginName(string UserName)
        {
            return Json(!db.slsoft_ias_sys_t_user.Any(m => m.UserName == UserName), JsonRequestBehavior.AllowGet);

        }

        public JsonResult CheckPassword(string OldPassword)
        {
            return Json(!db.slsoft_ias_sys_t_user.Any(m => m.UserID == Convert.ToInt32(Session["UserID"].ToString()) && m.Password == OldPassword), JsonRequestBehavior.AllowGet);

        }


        #region 生成验证码
        //// <summary>
        /// 生成验证码
        /// </summary>
        /// <param name="length">指定验证码的长度</param>
        /// <returns></returns>
        public string CreateValidateCode(int length)
        {
            int[] randMembers = new int[length];
            int[] validateNums = new int[length];
            string validateNumberStr = "";
            //生成起始序列值
            int seekSeek = unchecked((int)DateTime.Now.Ticks);
            Random seekRand = new Random(seekSeek);
            int beginSeek = (int)seekRand.Next(0, Int32.MaxValue - length * 10000);
            int[] seeks = new int[length];
            for (int i = 0; i < length; i++)
            {
                beginSeek += 10000;
                seeks[i] = beginSeek;
            }
            //生成随机数字
            for (int i = 0; i < length; i++)
            {
                Random rand = new Random(seeks[i]);
                int pownum = 1 * (int)Math.Pow(10, length);
                randMembers[i] = rand.Next(pownum, Int32.MaxValue);
            }
            //抽取随机数字
            for (int i = 0; i < length; i++)
            {
                string numStr = randMembers[i].ToString();
                int numLength = numStr.Length;
                Random rand = new Random();
                int numPosition = rand.Next(0, numLength - 1);
                validateNums[i] = Int32.Parse(numStr.Substring(numPosition, 1));
            }
            //生成验证码
            for (int i = 0; i < length; i++)
            {
                validateNumberStr += validateNums[i].ToString();
            }
            return validateNumberStr;
        }


        /// <summary>
        /// 创建验证码的图片
        /// </summary>
        /// <param name="containsPage">要输出到的page对象</param>
        /// <param name="validateNum">验证码</param>
        public byte[] CreateValidateGraphic(string validateCode)
        {
            Bitmap image = new Bitmap((int)Math.Ceiling(validateCode.Length * 12.0), 22);
            Graphics g = Graphics.FromImage(image);
            try
            {
                //生成随机生成器
                Random random = new Random();
                //清空图片背景色
                g.Clear(Color.White);
                //画图片的干扰线
                for (int i = 0; i < 25; i++)
                {
                    int x1 = random.Next(image.Width);
                    int x2 = random.Next(image.Width);
                    int y1 = random.Next(image.Height);
                    int y2 = random.Next(image.Height);
                    g.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);
                }
                Font font = new Font("Arial", 12, (FontStyle.Bold | FontStyle.Italic));
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height),
                 Color.Blue, Color.DarkRed, 1.2f, true);
                g.DrawString(validateCode, font, brush, 3, 2);
                //画图片的前景干扰点
                for (int i = 0; i < 100; i++)
                {
                    int x = random.Next(image.Width);
                    int y = random.Next(image.Height);
                    image.SetPixel(x, y, Color.FromArgb(random.Next()));
                }
                //画图片的边框线
                g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);
                //保存图片数据
                MemoryStream stream = new MemoryStream();
                image.Save(stream, ImageFormat.Jpeg);
                //输出图片流
                return stream.ToArray();
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }
        }
        #endregion

        public ActionResult LoginOut()
        {
            Session["UserID"] = null;
            return RedirectToAction("Login");
        }
    }




}
