﻿using Repository_Mvc_Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Repository_Mvc_Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var app = (MvcApplication)sender;
            var context = app.Context;
            var ex = app.Server.GetLastError();
            context.Response.Clear();
            context.ClearError();

            var httpException = ex as HttpException;

            var routeData = new RouteData();
            routeData.Values["controller"] = "errors";
            routeData.Values["exception"] = ex;
            routeData.Values["action"] = "Http500";

            if (httpException != null)
            {
                switch (httpException.GetHttpCode())
                {
                    case 404:
                        routeData.Values["action"] = "Http404";
                        break;
                    case 500:
                        routeData.Values["action"] = "Http500";
                        break;
                }
            }

            IController controller = new ErrorsController();
            controller.Execute(new RequestContext(new HttpContextWrapper(context), routeData));
        }
    }
}
