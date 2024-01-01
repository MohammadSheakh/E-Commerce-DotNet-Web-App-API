using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace E_Commerce_Web_App_API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        //protected void Application_Start()
        //{
        //    GlobalConfiguration.Configure(WebApiConfig.Register);
        //}

        protected void Application_Start()
        {
            // Configure Web API
            GlobalConfiguration.Configure(WebApiConfig.Register);

            // Configure JSON formatting to ignore reference loops
            HttpConfiguration config = GlobalConfiguration.Configuration;

            config.Formatters.JsonFormatter
                  .SerializerSettings
                  .ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }
    }
}
