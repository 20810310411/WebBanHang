using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Areas.Admin.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: Admin/SanPham
        public ActionResult DanhSach()
        {
            WebThuCungEntities db = new WebThuCungEntities();
            List<SanPham> danhsachSanPham = db.SanPhams.ToList();
            return View(danhsachSanPham);
        }
        public ActionResult ThemMoi()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoi(SanPham model)
        {
            WebThuCungEntities db = new WebThuCungEntities();
            db.SanPhams.Add(model);
            db.SaveChanges();
            return RedirectToAction("DanhSach");
        }
        public ActionResult CapNhat(int id)
        {
            WebThuCungEntities db = new WebThuCungEntities();
            SanPham model2 = db.SanPhams.Find(id);

            return View(model2);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult CapNhat(SanPham model)
        {
            WebThuCungEntities db = new WebThuCungEntities();
            var updateModel = db.SanPhams.Find(model.ID);
            updateModel.TenSP = model.TenSP;
            updateModel.GiaBan = model.GiaBan;
            updateModel.GiaCu = model.GiaCu;
            updateModel.New_Hot = model.New_Hot;
            updateModel.SoLuongTon = model.SoLuongTon;
            updateModel.SoLuongBan = model.SoLuongBan;
            updateModel.SoLuotDanhGia = model.SoLuotDanhGia;
            updateModel.Image1 = model.Image1;
            updateModel.Image2 = model.Image2;
            updateModel.Image3 = model.Image3;
            updateModel.MoTa = model.MoTa;
            updateModel.IdLoaiSP = model.IdLoaiSP;


            db.SaveChanges();

            return RedirectToAction("DanhSach");
        }
        public ActionResult Xoa(int id)
        {
            WebThuCungEntities db = new WebThuCungEntities();
            var updateModel = db.SanPhams.Find(id);
            db.SanPhams.Remove(updateModel);
            db.SaveChanges();
            return RedirectToAction("DanhSach");
        }
    }
}