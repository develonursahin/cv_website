using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Repositories;
using CV.Models.Entity;
namespace CV.Controllers
{
    public class LanguageController : Controller
    {
        // GET: Language
        GenericRepository<Languages> repo = new GenericRepository<Languages>();
        public ActionResult Index()
        {
            var languages = repo.List();
            return View(languages);
        }
        [HttpGet]
        public ActionResult AddLanguage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddLanguage(Languages p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddLanguage");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteLanguage(int id)
        {
            var languages = repo.Find(x => x.ID == id);
            repo.TDelete(languages);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditLanguage(int id)
        {
            var languages = repo.Find(x => x.ID == id);
            return View(languages);
        }
        [HttpPost]
        public ActionResult EditLanguage(Languages t)
        {
            if (!ModelState.IsValid)
            {
                return View("EditSkill");
            }
            var languages = repo.Find(x => x.ID == t.ID);
            languages.LANGUAGE = t.LANGUAGE;
            languages.SUCCSESS = t.SUCCSESS;
            repo.TUpdate(languages);
            return RedirectToAction("Index");
        }
    }
}