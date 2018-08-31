using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class MYCricketersController : Controller
    {
        // GET: MYCricketers
        public string Index()
        {
            return "Hello this is My First Controller";
        }
        public string Welcome()
        {
            return "Welcome to My Cricketer Controller";
        }
    }
}