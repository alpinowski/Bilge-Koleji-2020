using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeKoleji2020.MVCUI.Areas.Ogretmen.Controllers
{
    public class OgretmenClassesController : Controller
    {
        // GET: Ogretmen/OgretmenClasses
        public ActionResult Index()
        {
            return View();
        }
    }
}