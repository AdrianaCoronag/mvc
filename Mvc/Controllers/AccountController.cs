using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class AccountController : Controller
    {
        // GET: MYCricketers
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome()
        {
            ViewBag.Message = "Sachin Tendulkar";
            return View();
        }
    }
}