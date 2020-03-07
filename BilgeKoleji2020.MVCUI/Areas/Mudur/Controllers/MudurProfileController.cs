using BilgeKoleji2020.COMMON.Tools;
using BilgeKoleji2020.MODEL.Entities;
using BilgeKoleji2020.MVCUI.Filter;
using BilgeKoleji2020.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeKoleji2020.MVCUI.Areas.Mudur.Controllers
{
    [AuthFilter]
    public class MudurProfileController : Controller
    {
        RegisterService db = new RegisterService();
        // GET: Mudur/MudurProfile
        public ActionResult Index()
        {
            return View(db.GetById(((Register)Session["login"]).ID));
        }
        public ActionResult Edit()
        {
            return View(db.GetById(((Register)Session["login"]).ID));
        }

      
    }
}