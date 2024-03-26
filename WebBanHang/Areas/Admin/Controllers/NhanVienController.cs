using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Areas.Admin.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: Admin/NhanVien
        public ActionResult DanhSach()
        {
            WebThuCungEntities db = new WebThuCungEntities();
            List<NhanVien> danhsachNhanVien = db.NhanViens.ToList();
            return View(danhsachNhanVien);
        }
        public ActionResult ThemMoi()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemMoi(NhanVien model)
        {
            WebThuCungEntities db = new WebThuCungEntities();
            db.NhanViens.Add(model);
            db.SaveChanges();
            return RedirectToAction("DanhSach");
        }
        public ActionResult CapNhat(int id)
        {
            WebThuCungEntities db = new WebThuCungEntities();
            NhanVien model2 = db.NhanViens.Find(id);

            return View(model2);
        }
        [HttpPost]
        public ActionResult CapNhat(NhanVien model)
        {
            WebThuCungEntities db = new WebThuCungEntities();
            var updateModel = db.NhanViens.Find(model.ID);
            updateModel.TenNhanVien = model.TenNhanVien;
            updateModel.UserName = model.UserName;
            updateModel.Password = model.Password;
            updateModel.SDT = model.SDT;
            updateModel.NgaySinh = model.NgaySinh;
            updateModel.ChucVu = model.ChucVu;

            db.SaveChanges();

            return RedirectToAction("DanhSach");
        }
        public ActionResult Xoa(int id)
        {
            WebThuCungEntities db = new WebThuCungEntities();
            var updateModel = db.NhanViens.Find(id);
            db.NhanViens.Remove(updateModel);
            db.SaveChanges();
            return RedirectToAction("DanhSach");
        }
    }
}