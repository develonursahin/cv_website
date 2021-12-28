using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Models.Entity;
using CV.Repositories;

namespace CV.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        GenericRepository<Welcome> repo=new GenericRepository<Welcome>();
        [HttpGet]
        public ActionResult Index()
        {
            var welcome = repo.List();
            return View(welcome);
        }
        [HttpPost]
        public ActionResult Index(About p)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            var t = repo.Find(x => x.ID == 1);
            t.DESCRIPTION = p.DESCRIPTION;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}