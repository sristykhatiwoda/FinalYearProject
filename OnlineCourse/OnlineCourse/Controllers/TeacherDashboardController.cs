using System;
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
        // GET: TeacherDashboard
        public ActionResult Index()
        {
            var news = db.News();
            return View();
        }
    }
}