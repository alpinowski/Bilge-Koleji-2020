using BilgeKoleji2020.MODEL.Entities;
using BilgeKoleji2020.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeKoleji2020.MVCUI.Areas.Mudur.Controllers
{
    public class MudurClassesController : Controller

    {
        // GET: Mudur/MudurClasses
        StudentService students = new StudentService();
        public ActionResult Index()
        {
            return View(students.GetActive().ToList());
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentAccount model)
        {
            model.ID = Guid.NewGuid();
            students.Add(model);
            students.Save();
            return RedirectToAction("Index");
        }

        public ActionResult Update(Guid id)
        {
            var updated = students.GetById(id);
            return View(updated);
        }
        [HttpPost]
        public ActionResult Update(StudentAccount model)
        {
            if (ModelState.IsValid)
            {
                students.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(Guid Id)
        {
            var deleted = students.GetById(Id);
            students.Remove(deleted);
            return View("Index");
        }

    }
}