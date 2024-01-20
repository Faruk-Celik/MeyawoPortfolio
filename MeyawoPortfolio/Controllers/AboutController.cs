using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeyawoPortfolio.Controllers
{
    public class AboutController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateProject() 
        {
            return View();
        }
    }
}