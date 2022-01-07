using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Models.Entity;
using CV.Repositories;

namespace CV.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        GenericRepository<Education> repo = new GenericRepository<Education>();
        public ActionResult Index()
        {
            var education = repo.List();
            return View(education);
        }
        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEducation(Education p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddEducation");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteEducation(int id)
        {
            var education =repo.Find(x=>x.ID==id);
            repo.TDelete(education);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditEducation(int id)
        {
            var education = repo.Find(x=>x.ID==id);
            return View(education);
        }
        [HttpPost]
        public ActionResult EditEducation(Education t)
        {
            if (!ModelState.IsValid)
            {
                return View("EditEducation");
            }
            var education = repo.Find(x => x.ID == t.ID);
            education.NAME=t.NAME;
            education.FACULTY=t.FACULTY;
            education.SECTION=t.SECTION;
            education.DESCRIPTION=t.DESCRIPTION;
            education.START=t.START;
            education.FINISH=t.FINISH;
            repo.TUpdate(education);
            return RedirectToAction("Index");
        }

    }
}