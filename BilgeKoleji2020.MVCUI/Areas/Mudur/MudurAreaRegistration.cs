﻿using System.Web.Mvc;

namespace BilgeKoleji2020.MVCUI.Areas.Mudur
{
    public class MudurAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Mudur";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Mudur_default",
                "Mudur/{controller}/{action}/{id}",
                new {controller="Home", action = "Index", id = UrlParameter.Optional }
                
            );
        }
    }
}