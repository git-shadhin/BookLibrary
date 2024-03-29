﻿using BookLibrary.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BookLibrary
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.Formatters.Add(new BrowserJsonFormatter());

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
