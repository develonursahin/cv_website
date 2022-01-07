using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Models.Entity;
using CV.Repositories;
namespace CV.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        GenericRepository<Admin>repo=new GenericRepository<Admin>();
        public ActionResult Index()
        {
            var liste = repo.List();
            return View(liste);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddAdmin");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAdmin(int id)
        {
            Admin t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult BringAdmin(int id)
        {
            Admin t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult BringAdmin(Admin p)
        {
            if (!ModelState.IsValid)
            {
                return View("BringAdmin");
            }
            Admin t = repo.Find(x => x.ID == p.ID);
            t.Username = p.Username;
            t.Password = p.Password;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}