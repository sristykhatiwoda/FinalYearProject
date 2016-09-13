using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineCourse.Models;
using OnlineCourse.DapperObject;
using System.Net;

namespace OnlineCourse.Controllers
{
    public class StudentDashboardController : Controller
    {
        private I_MS_Course dbCourse = new MS_CourseDA();
            // GET: StudentDashboard
        public ActionResult Index()
        {
            var courses = dbCourse.Courses();
            return View(courses);
        }
    }
}