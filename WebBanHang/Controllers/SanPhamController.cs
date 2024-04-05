using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;
using PagedList;
using PagedList.Mvc;
using System.Web.UI;

namespace WebBanHang.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        WebThuCungEntities db = new WebThuCungEntities();
        public ActionResult TrangSanPhamPartial() // hiển thị grid view
        {
            return PartialView();
        }
        public ActionResult TrangSanPhamPartial2() // hiển thị list view
        {
            return PartialView();
        }
        public ActionResult TrangSanPhamPartial3() // thanh lọc thể loại
        {
            return PartialView();
        }


        
        public ActionResult DmDog(int ? page, int ? id)
        {
            var chocanh = db.SanPhams.Where(x => x.IdLoaiSP == id).ToList();
            ViewBag.CC = chocanh;
            int pageSize = 9;
            int pageNum = (page ?? 1);
            return View(chocanh.ToPagedList(pageNum, pageSize));
        }
        public ActionResult DmCat(int ? page)
        {
            var meocanh = db.SanPhams.Where(x => x.IdLoaiSP == 2).ToList();
            ViewBag.MC = meocanh;
            int pageSize = 9;
            int pageNum = (page ?? 1);
            return View(meocanh.ToPagedList(pageNum, pageSize));
        }
        public ActionResult DmPhuKien(int? page)
        {
            var phukien = db.SanPhams.Where(x => x.IdLoaiSP == 3).ToList();
            ViewBag.PK = phukien;
            int pageSize = 9;
            int pageNum = (page ?? 1);
            return View(phukien.ToPagedList(pageNum, pageSize));
        }
      


        public ActionResult PhanLoaiSP(int? page, int ? idphanloai)
        {
            var timsptheoloai = db.SanPhams.Where(x => x.IdLoaiSP == idphanloai).ToList();           
            int pageSize = 9;
            int pageNum = (page ?? 1);
            return View(timsptheoloai.ToPagedList(pageNum, pageSize));
        }
    }
}