using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewStudentProject.Controllers
{
    public class HomeController : Controller
    {
        //address/controller/action method
        //index action method
        public ActionResult Index()
        {
            return View();
        }

        //about action method
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //contact action method
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}