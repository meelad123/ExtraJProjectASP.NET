using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlaktData.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection collection) 
        {
            if (Session["user"] == null)
            {
                Models.User u = new Models.User();
                u.userName = collection["user"];
                u.password = collection["password"];
                if (SecurityUtility.AuthenticateUser(u))
                {
                    return RedirectToAction("Index", "Staff");
                }
                else
                {
                    ViewBag.WrongInfo = "Fel info! Försök igen.";
                    return View("Index");
                }
            }
            else
            {
                return RedirectToAction("Index", "Staff");
            }
           
        }
    }
}
