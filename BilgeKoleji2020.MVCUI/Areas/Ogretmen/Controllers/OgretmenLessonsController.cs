using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeKoleji2020.MVCUI.Areas.Ogretmen.Controllers
{
    public class OgretmenLessonsController : Controller
    {
        // GET: Ogretmen/OgretmenLessons
        public ActionResult Index()
        {
            return View();
        }
    }
}