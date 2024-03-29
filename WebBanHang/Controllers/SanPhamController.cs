using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        WebThuCungEntities db = new WebThuCungEntities();
        public ActionResult TrangSanPhamPartial() // grid view
        {
            return PartialView();
        }
        public ActionResult TrangSanPhamPartial2() // list view
        {
            return PartialView();
        }
        public ActionResult DmDog()
        {
            var chocanh = db.SanPhams.Where(x => x.IdLoaiSP == 1).ToList();
            ViewBag.CC = chocanh;
            return View(chocanh);
        }
        public ActionResult DmCat()
        {
            var meocanh = db.SanPhams.Where(x => x.IdLoaiSP == 2).ToList();
            ViewBag.MC = meocanh;
            return View(meocanh);
        }
        public ActionResult DmPhuKien()
        {
            var phukien = db.SanPhams.Where(x => x.IdLoaiSP == 3).ToList();
            ViewBag.PK = phukien;
            return View(phukien);
        }
    }
}