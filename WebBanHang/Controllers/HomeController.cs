using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    public class HomeController : Controller
    {
        WebThuCungEntities db = new WebThuCungEntities();
        public ActionResult Index()
        {
            var ds = db.SanPhams.ToList();
            ViewBag.All = ds;
            var noibat = db.SanPhams.Where(x => x.NB_BC == "noibat").ToList();
            ViewBag.NB = noibat;
            var banchay = db.SanPhams.Where(x => x.NB_BC == "banchay").ToList();
            ViewBag.BC = banchay;
            return View(ds);
        }
        public ActionResult TrangChuPartial()
        {
            return PartialView();
        }
        public ActionResult Shop()
        {
            return View();
        }

        public ActionResult ShopDetail()
        {
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }

        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult MyAccount()
        {
            return View();
        }
        public ActionResult Wishlist()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
    }
}