using BilgeKoleji2020.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeKoleji2020.MVCUI.Areas.Mudur.Controllers
{
    public class MudurLessonsController : Controller
    {
        // GET: Mudur/MudurLessons
        LessonsService lessons = new LessonsService();
        public ActionResult Index()
        {
            return View(lessons.GetActive().ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
    }
}