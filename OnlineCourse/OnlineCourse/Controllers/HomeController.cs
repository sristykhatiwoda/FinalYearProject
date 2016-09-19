using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using OnlineCourse.DapperObject;
using OnlineCourse.Models;


namespace OnlineCourse.Controllers
{
    public class HomeController : Controller
    {
        private I_STU_Student db = new STU_StudentDA();
        private I_MS_Batch dbBatch = new MS_BatchDA();
        private I_MS_Faculty dbFaculty = new MS_FacultyDA();
        private I_MS_Semester dbSemester = new MS_SemesterDA();
        private I_SC_User dbUser = new SC_UserDA();
        public ActionResult Index()
        {
            ViewBag.BatchID = new SelectList(dbBatch.Batches(), "BatchID", "Year");
            ViewBag.FacultyID = new SelectList(dbFaculty.Faculties(), "FacultyID", "FacultyTitle");
            ViewBag.SemesterID = new SelectList(dbSemester.Semesters(), "SemesterID", "SemesterTitle");
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
        public ActionResult Home(STU_Student student)
        {

            if (ModelState.IsValid)
            {  
                db.Add(student);
                return RedirectToAction("Index", "StudentDashboard");
            }
            return View();
        }
        public ActionResult StudentLogin(STU_Student student)
        {

            if (ModelState.IsValid)
            {
                STU_Student login = db.LoginStudentExists(student.Username, student.Password);
                if (login != null)
                {
                    Session["User"] = student.Username;
                    return RedirectToAction("Index", "StudentDashboard");
                }

                else
                {
                    ModelState.AddModelError("", "Login data is incorrect!");
                 
                    return RedirectToAction("StudentLogin", "Home");
                }

            }
            return View();
        }

    }
}