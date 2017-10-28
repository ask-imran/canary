using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Canary.Common.Models;

namespace Canary.Controllers
{
    public class _CarouselPartialController : Controller
    {
        [ChildActionOnly]
        public ActionResult Index()
        {
            var _carouselList = new List<CarouselInfo>();
            _carouselList.Add(new CarouselInfo
            {
                ImageCss = "text-left",
                CarouselHeaderText = "Example headline.",
                CarouselDescription = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.",
                CarouselImageSrc = "data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw=="
            });
            _carouselList.Add(new CarouselInfo
            {
                ImageCss = "",
                CarouselHeaderText = "Another example headline.",
                CarouselDescription = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.",
                CarouselImageSrc = "data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw=="
            });
            _carouselList.Add(new CarouselInfo
            {
                ImageCss = "text-right",
                CarouselHeaderText = "One more for good measure.",
                CarouselDescription = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.",
                CarouselImageSrc = "data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw=="
            });
            return PartialView("_carousel", _carouselList);
        }
	}
}
namespace Canary.Common.Models
{
    public class CarouselInfo
    {
        public string CarouselHeaderText { get; set; }
        public string CarouselImageSrc { get; set; }
        public string CarouselDescription { get; set; }
        public string ImageCss { get; set; }
    }
}
