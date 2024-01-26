using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities(); 
        public ActionResult Index()
        {
           
            return View();
        }
        public PartialViewResult HeadPartial ()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial ()
        {
            return PartialView();
        }
        public PartialViewResult FeaturePartial ()
        {
            var values =db.TblFuture.ToList();
            return PartialView(values);
        }
        public PartialViewResult AboutPartial () 
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult ServicePartial ()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PortfolioPartial ()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult ReferencesPartial ()
        {
            var values = db.TblReferences.ToList();
            return PartialView(values);
        }
        public PartialViewResult ContactPartial ()
        {
            var values = db.TblContact.ToList();
            return PartialView(values);
        }
        public PartialViewResult FooterPartial () 
        {
            var values = db.TblSocialMedia.ToList();
            return PartialView(values);
        }
        public PartialViewResult SectionPartial ()
        {
            return PartialView();
        }
    }
}