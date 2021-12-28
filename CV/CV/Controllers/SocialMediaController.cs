using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Models.Entity;
using CV.Repositories;

namespace CV.Controllers
{
    public class SocialMediaController : Controller
    {
        // GET: SocialMedia
        GenericRepository<SocialMedia> repo = new GenericRepository<SocialMedia> ();
        public ActionResult Index()
        {
            var data = repo.List();
            return View(data);
        }
        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSocialMedia(SocialMedia p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult BringSocialMedia(int id)
        {
            var account = repo.Find(x=>x.ID == id);
            return View(account);
        }
        [HttpPost]
        public ActionResult BringSocialMedia(SocialMedia p)
        {
            var account = repo.Find(x => x.ID == p.ID);
            account.ID = p.ID;
            account.Status = true;
            account.Media = p.Media;
            account.İcon = p.İcon;
            account.Link = p.Link;
            repo.TUpdate(account);
            return RedirectToAction("Index");
        }
        public ActionResult StatusChangeSocialMedia(int id)
        {
            var account = repo.Find(x => x.ID == id);
            if(account.Status == false)
            {
                account.Status = true;
            }
            else
            {
                account.Status = false;
            }
            repo.TUpdate(account);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSocialMedia(int id)
        {
            var account = repo.Find(x=>x.ID==id);
            repo.TDelete(account);
            return RedirectToAction("Index");
        }
    }
}