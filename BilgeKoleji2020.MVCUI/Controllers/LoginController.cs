using BilgeKoleji2020.MODEL.Entities;
using BilgeKoleji2020.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 

namespace BilgeKoleji2020.MVCUI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        TeachersService service = new TeachersService();
        StudentService student = new StudentService();
        public ActionResult Ogrenci()
        {
         
            return View();
        }
        [HttpPost]
        public ActionResult Ogrenci(string TcKimlikNumarasi, string OkulNumarasi)
        {
            
            if (student.Any(i => i.TCKimlikNumarasi == TcKimlikNumarasi && i.OkulNumarasi==OkulNumarasi))
            {
                return View("Index", "Ogrenci");
            }

            return View();
        }

        public ActionResult Ogretmen()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Ogretmen(string UserName, string Password)
        {
            //var ogretmen = service.GetByDefault(i => i.UserName == UserName && i.Password == Password);
            if (service.Any(i=>i.Username==UserName && i.Password==Password))
            {
               return View("Index", "Ogretmen"/*,ogretmen*/);
            }

            return View();
        }

        public ActionResult Register()
        {
            
            return View();
        }

        
    }
}