using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class ContactController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index ()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }
        public ActionResult DeleteContact ( int id )
        {
            var value = db.TblContact.Find(id);
            db.TblContact.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult OpenMessage ( int id )
        {
            var value = db.TblContact.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult OpenMessage ( TblContact p )
        {
            var value = db.TblContact.Find(p.ContactID);
            value.Message = p.Message;
            value.SendDate = p.SendDate;
            value.NameSurname = p.NameSurname;
            value.Email = p.Email;
            value.IsRead = p.IsRead; 
            value.MessageCategory = p.MessageCategory;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}