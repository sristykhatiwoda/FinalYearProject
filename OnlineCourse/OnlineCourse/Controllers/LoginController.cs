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
        private I_SC_UserType dbType = new SC_UserTypeDA();
        // GET: Login
        public ActionResult Index()
        {
            ViewBag.UserTypeID = new SelectList(dbType.UserTypes(), "UserTypeID", "Type");
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
        
            return View();
        }
        [HttpPost]
        public ActionResult Login(SC_User user)
        {
            if (ModelState.IsValid)
            {       
                SC_User login = db.LoginUserExists(user.Username, user.Password,user.UserTypeID);
                
                if (login != null && login.UserTypeID=="1")
                {
                    Session["User"] = user.Username;
                    return RedirectToAction("Index", "SC_UserType");
                }
                else if(login!=null && login.UserTypeID=="2")
                {
                    Session["User"] = user.Username;
                    return RedirectToAction("Index", "SC_User");
                }
            }
            ModelState.AddModelError("", "Login data is incorrect");
            return RedirectToAction("Index", "Login");
       
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}