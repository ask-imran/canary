using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Canary.Controllers
{
    public class HomeController : SiteBaseController
    {
        public ActionResult Index()
        {
            return View();

        }
    }
}