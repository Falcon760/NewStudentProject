using NewStudentProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewStudentProject.Controllers



{

    


    public class XYZController : Controller
    {
        //db is instance of the schoolcontext that is the database
        private SchoolContext db = new SchoolContext();

        //
        // GET: /XYZ/
        public ActionResult ABC()
        {

            var students = db.Students.ToList();



            //Student alex = new Student();
            //alex.FirstName = "Alex";

            //searches for a folder matching the name XYZ
            //
            return View(students);
        }

        public ActionResult Index()
        {
            return View();
        }
	}
}