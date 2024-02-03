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
        public ActionResult MarkAsRead ( int id )
        {
            var message = db.TblContact.Find(id);
            message.IsRead = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Create ( string NameSurname, string Email, string Message )
        {
            TblContact newContact = new TblContact
            {
                NameSurname = NameSurname,
                Email = Email,
                Message = Message,
                SendDate = DateTime.Now,
                IsRead = false
            };

            db.TblContact.Add(newContact);
            db.SaveChanges();

            return RedirectToAction("Index"); // İşlem tamamlandıktan sonra kullanıcıyı yönlendir
        }
    }
}