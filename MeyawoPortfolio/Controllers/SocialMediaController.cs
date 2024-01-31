using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index ()
        {
            var values = db.TblSocialMedia.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSocialMedia ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSocialMedia ( TblSocialMedia p )
        {
            db.TblSocialMedia.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSocialMedia ( int id )
        {
            var value = db.TblSocialMedia.Find(id);
            db.TblSocialMedia.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateSocialMedia ( int id )
        {
            var value = db.TblSocialMedia.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia ( TblSocialMedia p )
        {
            var value = db.TblSocialMedia.Find(p.SocialMediaID);
            value.SocialMediaUrl = p.SocialMediaUrl;
            value.Title = p.Title;
            value.Icon = p.Icon;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}