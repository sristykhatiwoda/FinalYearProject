using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineCourse.DapperObject;
using OnlineCourse.Models;
using System.IO;
using System.Data;

namespace OnlineCourse.Controllers
{
    public class LoginController : Controller
    {
        private I_SC_User db = new SC_UserDA();
        private I_SC_UserType dbtype = new SC_UserTypeDA();
        private I_STU_Student dbS = new STU_StudentDA();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(SC_User user,STU_Student student)
        {
            if (ModelState.IsValid)
            {
                // User user = new User();                
                SC_User login = db.LoginUserExists(user.Username, user.Password);
                
                // bool LoginUserExists = user.LoginUserExists(user.Username, user.Password);
                if (login != null)
                {
                    Session["User"] = user.Username;
                    return RedirectToAction("Index", "Dashboard");
                }
          
                else
                {
                    ModelState.AddModelError("", "Login data is incorrect!");
                    ViewBag.LoginError = "Incorrect username or password"; 
                }
               
            }
            return RedirectToAction("Index", "Login");
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}