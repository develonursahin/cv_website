using CV.Models.Entity;
using CV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Controllers
{
    
    public class AboutController : Controller
    {
        // GET: About
        CVEntities db = new CVEntities();
        GenericRepository<About> repo = new GenericRepository<About>();
        [HttpGet]
        public ActionResult Index()
        {
            var abouts = repo.List();
            return View(abouts);
        }
        [HttpPost]
        public ActionResult Index(About p)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            var t = repo.Find(x => x.ID == 1);
            t.FIRSTNAME = p.FIRSTNAME;
            t.SECONDNAME = p.SECONDNAME;
            t.SURNAME = p.SURNAME;
            t.BIRTHDAY = p.BIRTHDAY;
            t.PHONE = p.PHONE;
            t.EMAIL = p.EMAIL;
            t.DESCRIPTION = p.DESCRIPTION;
            t.LOCATION = p.LOCATION;
            t.DRIVINGLICENCE = p.DRIVINGLICENCE;
            t.PHOTO = p.PHOTO;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}