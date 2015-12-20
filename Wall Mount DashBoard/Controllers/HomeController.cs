using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Wall_Mount_DashBoard.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
