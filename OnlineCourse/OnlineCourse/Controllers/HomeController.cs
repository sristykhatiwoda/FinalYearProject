using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineCourse.DapperObject;
using OnlineCourse.Models;


namespace OnlineCourse.Controllers
{
    public class HomeController : Controller
    {
        private I_MS_Batch dbBatch = new MS_BatchDA();
        private I_MS_Faculty dbFaculty = new MS_FacultyDA();
        private I_MS_Semester dbSemester = new MS_SemesterDA();
        public ActionResult Index()
        {
            ViewBag.UserTypeID = new SelectList(dbBatch.Batches(), "BatchID", "Year");
            ViewBag.UserTypeID = new SelectList(dbFaculty.Faculties(), "FacultyID", "Faculty");
            ViewBag.UserTypeID = new SelectList(dbSemester.Semesters(), "SemesterID", "Semester");
            return View();
            
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
    }
}