using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDACS.Models;

namespace WebDACS.Controllers
{
    public class TrangChuController : Controller
    {
        // GET: TrangChu
        dbStockDataContext data = new dbStockDataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult product()
        {
            var model = (from a in data.STOCKs select a).ToList();
            return PartialView(model);
        }
        public ActionResult ChuDe()
        {
            var model = (from a in data.CHUDEs select a).ToList();
            return PartialView(model);
        }
    }
}