using MichaelResumeApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MichaelResumeApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); //.axd extension is for files that don't exist on filesystem, but are used for debugging purposes
                                                              //better to include this route because it won't try to map to something that doesn't exist

            var namespaces = new[] { typeof(PostsController).Namespace };

            routes.MapRoute("Login", "login", new { controller = "Auth", action = "Login" }, namespaces);

            routes.MapRoute("Home", "", new {controller = "Posts", action = "Index" }, namespaces); 
          
        }
    }
}