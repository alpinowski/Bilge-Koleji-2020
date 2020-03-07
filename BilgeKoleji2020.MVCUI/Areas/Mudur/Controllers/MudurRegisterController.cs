using BilgeKoleji2020.MODEL.Entities;
using BilgeKoleji2020.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeKoleji2020.MVCUI.Areas.Mudur.Controllers
{
    public class MudurRegisterController : Controller
    {
        StudentService db = new StudentService();
        
        // GET: Register
        public ActionResult Student()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Student(StudentAccount account)
        {
            if (ModelState.IsValid)
            {
                db.Add(account);
                db.Save();
                return RedirectToAction("Index", "MudurStudent", new { Areas = "Mudur" });
            }
            return View();
        }
        public ActionResult Index()
        {
            
            return View();
        }
    }
}
