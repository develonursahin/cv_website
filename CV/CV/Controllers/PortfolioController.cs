using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Models.Entity;
using CV.Repositories;

namespace CV.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        GenericRepository<Portfolio> repo = new GenericRepository<Portfolio>();
        public ActionResult Index()
        {
            var portfolio = repo.List();
            return View(portfolio);
        }
        [HttpGet]
        public ActionResult AddPortfolio()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPortfolio(Portfolio p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddPortfolio");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeletePortfolio(int id)
        {
            var portfolio = repo.Find(x => x.ID == id);
            repo.TDelete(portfolio);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditPortfolio(int id)
        {
            var portfolio = repo.Find(x => x.ID == id);
            return View(portfolio);
        }
        [HttpPost]
        public ActionResult EditPortfolio(Portfolio t)
        {
            if (!ModelState.IsValid)
            {
                return View("EditPortfolio");
            }
            var portfolio = repo.Find(x => x.ID == t.ID);
            portfolio.PROJECT = t.PROJECT;
            portfolio.DEFINITION = t.DEFINITION;
            portfolio.IMAGEURL = t.IMAGEURL;
            portfolio.PROJECTURL = t.PROJECTURL;
            repo.TUpdate(portfolio);
            return RedirectToAction("Index");
        }
    }
}