using BilgeKoleji2020.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeKoleji2020.MVCUI.Controllers
{
    public class HomeController : Controller
    {
        
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
        public ActionResult PreRegister(PreRegister model, HttpPostedFileBase User) 
        {
           
            
            return View("RegisterOK");
        }
        public ActionResult PreRegisterOK()
        {
            
            return View();
        }
    }
}