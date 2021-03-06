﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using OnlineCourse.Models;
using OnlineCourse.DapperObject;

namespace OnlineCourse.Controllers
{
    public class TeacherDashboardController : Controller
    {
        private I_NEW_News db = new NEW_NewsDA();
        private I_MS_Course dbCourse = new MS_CourseDA();
        // GET: TeacherDashboard
        public ActionResult Index()
        {
            var news = db.News();
            return View(news);
        }

        public ActionResult LoadCoursesAssignment()
        {
            var courses = dbCourse.Courses();
            return PartialView(courses);
        }

        public ActionResult LoadCoursesUploads()
        {
            var courses = dbCourse.Courses();
            return PartialView(courses);
        }

        //public ActionResult NewsDescription()
        //{
        //    var news = db.News();
        //    return View(news);
        //}
    }
}