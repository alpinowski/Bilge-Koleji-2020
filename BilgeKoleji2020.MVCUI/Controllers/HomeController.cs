using BilgeKoleji2020.MODEL.Entities;
using BilgeKoleji2020.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeKoleji2020.MVCUI.Controllers
{
    
    public class HomeController : Controller
    {
        PreRegisterService db = new PreRegisterService();

        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult PreRegister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PreRegister(PreRegister register) 
        {
            if (ModelState.IsValid)
            {
                db.Add(register);
                db.Save();
                return RedirectToAction("Index", "MudurRegister", new { Areas = "Mudur" });
            }
            
            return View();
        }
        
    }
}