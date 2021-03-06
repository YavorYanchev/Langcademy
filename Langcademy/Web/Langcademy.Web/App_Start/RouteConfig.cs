﻿namespace Langcademy.Web
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.LowercaseUrls = true;

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Topics", action = "Index", id = UrlParameter.Optional });
        }
    }
}
