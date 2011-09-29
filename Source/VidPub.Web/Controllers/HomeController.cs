using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPub.Web.Infrastructure.Logging;

namespace VidPub.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger logger;

        public HomeController(ILogger logger)
        {
            this.logger = logger;
        }


        public ActionResult Index()
        {
            logger.LogInfo("Home Page Called");
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
