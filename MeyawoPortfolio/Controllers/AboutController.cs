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
        public ActionResult Index ()
        {
            return View();
        }

    }
}
//}
//@{
//    Layout = null;
//}

//< !doctype html >
//< html lang = "en" >
//@Html.Partial("~/Views/AdminLayout/_HeaderPartial.cshtml")
//< body >
//    < div class= "wrapper d-flex align-items-stretch" >
//        @Html.Partial("~/Views/AdminLayout/_SidebarPartial.cshtml")
//        < div id = "content" class= "p-4 p-md-5 pt-5" >
//            @RenderBody()
//        </ div >
//    </ div >
//    @Html.Partial("~/Views/AdminLayout/_ScriptPartial.cshtml")
//</ body >
//</ html >