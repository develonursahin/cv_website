using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Models.Entity;
using CV.Repositories;

namespace CV.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        ExperienceRepository repo = new ExperienceRepository();

        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddExperience(Experience p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddExperience");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteExperience(int id)
        {
            Experience t = repo.Find(x=> x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult BringExperience(int id)
        {
            Experience t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult BringExperience(Experience p)
        {
            if (!ModelState.IsValid)
            {
                return View("BringExperience");
            }
            Experience t = repo.Find(x => x.ID == p.ID);
            t.COMPANY = p.COMPANY;
            t.POSITION = p.POSITION;
            t.SECTOR = p.SECTOR;
            t.WAYOFWORKING = p.WAYOFWORKING;
            t.START = p.START;
            t.FINISH = p.FINISH;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}