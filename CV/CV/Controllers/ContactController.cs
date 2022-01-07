using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Models.Entity;
using CV.Repositories;
namespace CV.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        GenericRepository<Contact> repo = new GenericRepository<Contact>(); 
        public ActionResult Index()
        {
            var messages=repo.List();
            return View(messages);
        }
        public ActionResult DeleteContact(int id)
        {
            var contact = repo.Find(x => x.ID == id);
            repo.TDelete(contact);
            return RedirectToAction("Index");
        }
    }
}