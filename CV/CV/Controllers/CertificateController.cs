using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Models.Entity;
using CV.Repositories;
namespace CV.Controllers
{
    public class CertificateController : Controller
    {
        // GET: Certificate
        GenericRepository<Certificate> repo = new GenericRepository<Certificate>();
        public ActionResult Index()
        {
            var certificate = repo.List();
            return View(certificate);
        }
        [HttpGet]
        public ActionResult BringCertificate(int id)
        {
            var certificate = repo.Find(x=>x.ID == id);
            ViewBag.d = id;
            return View(certificate);
        }
        [HttpPost]
        public ActionResult BringCertificate(Certificate t)
        {
            if (!ModelState.IsValid)
            {
                return View("BringCertificate");
            }
            var certificate = repo.Find(x => x.ID == t.ID);
            certificate.NAME=t.NAME;
            certificate.CORPORATION=t.CORPORATION;
            certificate.URL=t.URL;
            certificate.DATE=t.DATE;
            repo.TUpdate(certificate);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddCertificate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCertificate(Certificate p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddCertificate");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCertificate(int id)
        {
            var certificate = repo.Find(x=>x.ID==id);
            repo.TDelete(certificate);
            return RedirectToAction("Index");
        }
    }
}