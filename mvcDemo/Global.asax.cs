using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace mvcDemo // globel.asax.cs ==>like startup  file 
{
    public class MvcApplication : System.Web.HttpApplication
    {
        // When first user use an application When the app is Publish os go here
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //RegisterBundles ==> go to Defination ==> App_Start /BundlConfig.cs

        }
    }
}
