using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Models.Entity;
using CV.Repositories;

namespace CV.Controllers
{
    public class InterestController : Controller
    {
        // GET: Interest
        GenericRepository<Interests> repo=new GenericRepository<Interests>();
        [HttpGet]
        public ActionResult Index()
        {
            var interests=repo.List();
            return View(interests);
        }
        [HttpPost]
        public ActionResult Index(Interests p)
        {
            //if (!ModelState.IsValid)
            //{
                //return View("Index");
            //}
            var t=repo.Find(x=>x.ID==1);
            t.HEADER = p.HEADER;
            t.DESCRIPTION = p.DESCRIPTION;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
        public ActionResult AddInterest()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddInterest(Interests p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddInterest");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteInterest(int id)
        {
            var interests = repo.Find(x => x.ID == id);
            repo.TDelete(interests);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditInterest(int id)
        {
            var interests = repo.Find(x => x.ID == id);
            ViewBag.d = id;
            return View(interests);
        }
        [HttpPost]
        public ActionResult EditInterest(Interests p)
        {
            //if (!ModelState.IsValid)
         //{
         //return View("Index");
         //}
            var t = repo.Find(x => x.ID == 1);
            t.HEADER = p.HEADER;
            t.DESCRIPTION = p.DESCRIPTION;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}