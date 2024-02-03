using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class ReferencesController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblReferences.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateReference ()
        {
            return View();

        }
        [HttpPost]
        public ActionResult CreateReference (TblReferences p)
        {
            db.TblReferences.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult DeleteReference ( int id )
        {
            var value = db.TblReferences.Find(id);
            db.TblReferences.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateReference (int id )
        {
            var value =db.TblReferences.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateReference (TblReferences p)
        {
            var value = db.TblReferences.Find(p.ReferencesId);
            value.NameSurname = p.NameSurname;
            value.Status = p.Status;    
            value.Description = p.Description;
            value.ImageUrl = p.ImageUrl;    
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    

    }
}