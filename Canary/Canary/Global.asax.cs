using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Canary.App_Start;
using System.Web.Optimization;

namespace Canary
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            IocConfigurator.Configure();
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
    }
}
