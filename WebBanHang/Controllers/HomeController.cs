using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using WebBanHang.Models;
using PagedList;
using PagedList.Mvc;

namespace WebBanHang.Controllers
{
    public class HomeController : Controller
    {
        WebThuCungEntities db = new WebThuCungEntities();
        public ActionResult Index(int ? page)
        {
            var ds = db.SanPhams.ToList();
            ViewBag.All = ds;
            var noibat = db.SanPhams.Where(x => x.NB_BC == "noibat").ToList();
            ViewBag.NB = noibat;
            //int pageSize = 8;
            //int pageNum = (page ?? 1);
            return View(noibat);
        }
        public ActionResult TrangChuPartial()
        {
            return PartialView();
        }
        public ActionResult Shop(int? page, int? idphanloai)
        {
            var ds = db.SanPhams.ToList();
            ViewBag.All = ds;
            int pageSize = 9;
            int pageNum = (page ?? 1);
            return View(ds.ToPagedList(pageNum, pageSize));
        }

        public ActionResult ChiTietSP(int id)
        {
            var ds = db.SanPhams.ToList();
            ViewBag.All = ds;
            var ctsp = db.SanPhams.Where(x => x.ID == id);
            ViewBag.CTSP = ctsp;
            return View();
        }
        public ActionResult ChiTietSPPartial()
        {
            return PartialView();
        }
        public ActionResult ReviewPartial()
        {
            return PartialView();
        }
        public ActionResult SPLienQuanPartial()
        {
            return PartialView();
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