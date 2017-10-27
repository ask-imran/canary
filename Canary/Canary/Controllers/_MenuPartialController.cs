using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Canary.Common.CustomConfiguration;

namespace Canary.Controllers
{
    public class _MenuPartialController : Controller
    {
        [ChildActionOnly]
        public ActionResult Index()
        {
            return PartialView("_menu", CustomConfiguration.GetAvailableMenus());
        }
	}
}