using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineCourse.Models;
using OnlineCourse.DapperObject;
using System.Web.Mvc;

namespace OnlineCourse.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        private I_STU_Student db = new STU_StudentDA();
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register(STU_Student student)
        {
            
            if (ModelState.IsValid)
            {
                db.Add(student);
            }
            return View();
        }
    }
}