using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodSec.Controllers
{

    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            ViewBag.Message = "This is the Add Page";

            return View();
        }

        public ActionResult List()
        {
            ViewBag.Message = "This is the List Page";

            return View();
        }
    }
}