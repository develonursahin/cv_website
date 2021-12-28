using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Models.Entity;

namespace CV.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        CVEntities db = new CVEntities();
        public PartialViewResult Welcome()
        {
            var welcome = db.Welcome.ToList();
            return PartialView(welcome);
        }
        public ActionResult Index()
        {
            var degerler=db.About.ToList();
            return View(degerler);
        }
        public PartialViewResult SocialMedia()
        {
            var socialmedia = db.SocialMedia.Where(x=>x.Status==true).ToList();
            return PartialView(socialmedia);
        }
        public PartialViewResult Experience()
        {
            var experiences=db.Experience.ToList();
            return PartialView(experiences);
        }
        public PartialViewResult Education()
        {
            var educations = db.Education.ToList();
            return PartialView(educations);
        }
        public PartialViewResult Skills()
        {
            var skills = db.Skills.ToList();
            return PartialView(skills);
        }
        public PartialViewResult Portfolio()
        {
            var portfolios = db.Portfolio.ToList();
            return PartialView(portfolios);
        }

        public PartialViewResult Interests()
        {
            var interests = db.Interests.ToList();
            return PartialView(interests);
        }
        public PartialViewResult Certificates()
        {
            var certificates = db.Certificate.ToList();
            return PartialView(certificates);
        }
        public PartialViewResult Languages()
        {
            var languages = db.Languages.ToList();
            return PartialView(languages);
        }
        [HttpGet]
        public PartialViewResult Contact()
        {
            
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Contact(Contact c)
        {
            c.DATE= DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Contact.Add(c);
            db.SaveChanges();
            return PartialView();
        }
    }
}