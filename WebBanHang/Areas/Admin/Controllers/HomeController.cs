using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebBanHang.Models;

namespace WebBanHang.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult TrangChu()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string user, string password)
        {
            //check db
            WebThuCungEntities db = new WebThuCungEntities();
            var nhanVien = db.NhanViens.SingleOrDefault(m =>m.UserName.ToLower() == user.ToLower() && m.Password == password );
            //check code 
            if (nhanVien != null)
            {
                Session["user"] = nhanVien;
                return RedirectToAction("TrangChu");
            }    
            else
            {
                TempData["error"] = "Tài khoản đăng nhập không đúng";
                return View();
            }
        }
        public ActionResult Logout()
        {
            Session.Remove("user");
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}