using BilgeKoleji2020.MODEL.Entities;
using BilgeKoleji2020.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Web.UI.WebControls;


namespace BilgeKoleji2020.MVCUI.Areas.Mudur.Controllers
{
    public class MudurRegisterController : Controller
    {
        // GET: Mudur/MudurRegister
        
        RegisterService register = new RegisterService();
        StudentService student = new StudentService();
        public ActionResult Index()
        {
            return View(register.GetActive().ToList());
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentAccount model)
        {

            model.ID = Guid.NewGuid();           
            student.Add(model);
            register.Save();
            return RedirectToAction("Index");
        }
       
        public ActionResult Update(Guid id)
        {
            var updated = register.GetById(id);
            return View(updated);
        }
        [HttpPost]
        public ActionResult Update(Register model)
        {
            if (ModelState.IsValid)
            {
                register.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(Guid Id)
        {
            var deleted = register.GetById(Id);
            register.Remove(deleted);
            return View("Index");
        }

        //[HttpPost, ActionName("Delete")]

            //delete'e basıldığında buraya gelince aynı update gibi dolu modeli indexine yolla sonra iki buton yap silmek istediğinizden emin misiniz evet ise üstteki deleteye yolla silsin hayıra basarsa direk indexe yollasın
        public ActionResult DeleteConfirmed(Guid Id)
        {
            register.Remove(register.GetById(Id));
            register.Save();
            return RedirectToAction("Delete");
        }
    }
}