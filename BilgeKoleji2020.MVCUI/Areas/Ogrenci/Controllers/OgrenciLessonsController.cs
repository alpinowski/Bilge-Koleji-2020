using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeKoleji2020.MVCUI.Areas.Ogrenci.Controllers
{
    public class OgrenciLessonsController : Controller
    {
        // GET: Ogrenci/OgrenciLessons
        public ActionResult Index()
        {
            return View();
        }
    }
}