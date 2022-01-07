using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using CV.Models.Entity;

namespace CV.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            CVEntities db = new CVEntities();
            var information = db.Admin.FirstOrDefault
                (x => x.Username == p.Username &&
                x.Password == p.Password);
            if (information != null)
            {
                FormsAuthentication.SetAuthCookie(information.Username, false);
                Session["Username"]=information.Username.ToString();
                return RedirectToAction("Index","Welcome");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}