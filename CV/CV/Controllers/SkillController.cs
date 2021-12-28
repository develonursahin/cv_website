using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Models.Entity;
using CV.Repositories;

namespace CV.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        GenericRepository<Skills> repo = new GenericRepository<Skills>();
        public ActionResult Index()
        {
            var skills = repo.List();
            return View(skills);
        }
        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(Skills p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddSkill");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSkill(int id)
        {
            var skill = repo.Find(x=>x.ID == id);
            repo.TDelete(skill);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditSkill(int id)
        {
            var skill = repo.Find(x => x.ID == id);
            return View(skill);
        }
        [HttpPost]
        public ActionResult EditSkill(Skills t)
        {
            if (!ModelState.IsValid)
            {
                return View("EditSkill");
            }
            var skill = repo.Find(x => x.ID == t.ID);
            skill.SKILL = t.SKILL;
            skill.SUCCSESS = t.SUCCSESS;
            repo.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}