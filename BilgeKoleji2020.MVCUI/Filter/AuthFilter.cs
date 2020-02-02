﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeKoleji2020.MVCUI.Filter
{
    public class AuthFilter:FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["login"]==null)
            {
                filterContext.Result = new RedirectResult("~/Mudur/Home/Index");
            }
        }
    }
}