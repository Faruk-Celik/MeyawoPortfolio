using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class DashboardController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
          
            ViewBag.CategoryCount = db.TblCategory.Count();
            ViewBag.ProjectCount = db.TblProject.Count();
            ViewBag.MessageCount = db.TblContact.Count();
            ViewBag.SocialMediaCount = db.TblSocialMedia.Count();
            ViewBag.ServiceCount = db.TblService.Count();
            ViewBag.CsharpProjectCount = db.TblProject.Where(x => x.ProjectCategory == 3).Count();
            ViewBag.AspNetMvcProjectCount = db.TblProject.Where(x => x.ProjectCategory == 1).Count();
            ViewBag.IsReadMessageCount = db.TblContact.Where(x => x.IsRead == false).Count();
            ViewBag.IsNotReadMessageCount = db.TblContact.Where(x => x.IsRead == true).Count();
            ViewBag.LastProjectName = db.LastProjectName().FirstOrDefault();
            ViewBag.LastServiceTitle = db.LastServiceTitle().FirstOrDefault();
            return View();
        }
    }

}