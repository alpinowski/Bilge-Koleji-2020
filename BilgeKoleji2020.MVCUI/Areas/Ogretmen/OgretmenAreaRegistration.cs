﻿using System.Web.Mvc;

namespace BilgeKoleji2020.MVCUI.Areas.Ogretmen
{
    public class OgretmenAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Ogretmen";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Ogretmen_default",
                "Ogretmen/{controller}/{action}/{id}",
                new {controller="Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}