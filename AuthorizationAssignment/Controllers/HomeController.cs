using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AuthorizationAssignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            if (User.IsInRole("Admin"))
            {
                return RedirectToAction("Admin", "Home");
            }
            if (User.IsInRole("Teacher"))
            {
                return RedirectToAction("Teacher", "Home");
            }

            if (User.IsInRole("Student"))
            {
                return RedirectToAction("Student", "Home");
            }
            else
            {
                return HttpNotFound();

            }
        }

        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Admin()
        {
            return View();
        }

        [Authorize(Roles = "Teacher")]
        public ActionResult Teacher()
        {
            return View();
        }

        [Authorize(Roles = "Student")]
        public ActionResult Student()
        {
            return View();
        }
    }
}