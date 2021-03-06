﻿using System;
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
        private I_NEW_News dbNews = new NEW_NewsDA();
            // GET: StudentDashboard
        public ActionResult Index()
        {
            var courses = dbCourse.Courses();
            
            return View(courses);
       
        }
      

        public ActionResult LoadNews()
        {
            var news = dbNews.News();
            return View(news);
        }

        public ActionResult LoadCoursesInAssignment()
        {
            var courses = dbCourse.Courses();
            return PartialView(courses);
        }

        public ActionResult LoadCoursesInQuiz()
        {
            var courses = dbCourse.Courses();
            return PartialView(courses);
        }
    }
}