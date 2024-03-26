using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanHang.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public ActionResult DmDog()
        {
            return View();
        }
        public ActionResult DmCat()
        {
            return View();
        }
        public ActionResult DmPhuKien()
        {
            return View();
        }
    }
}