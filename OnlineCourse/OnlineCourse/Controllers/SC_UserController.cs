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
    public class SC_UserController : Controller
    {
        private I_SC_User db = new SC_UserDA();
        private I_SC_UserType dbUserType = new SC_UserTypeDA();
        // GET: SC_User
        public ActionResult Index()
        {
            var user = db.Users();
            return View(user);
        }

        // GET: SC_User/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SC_User user = db.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: SC_User/Create
        public ActionResult Create()
        {
            ViewBag.UserTypeID = new SelectList(dbUserType.UserTypes(), "UserTypeID", "Type");
            return View();
        }

        // POST: SC_User/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "UserID,FirstName,MiddleName,LastName,"+
            "Email,Password,Phone,Address,UserTypeID")] SC_User user)
        {
            if (ModelState.IsValid)
            {
                db.Add(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: SC_User/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SC_User user = db.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserTypeID = new SelectList(dbUserType.UserTypes(), "UserTypeID", "Type",user.UserTypeID);
            return View(user);
        }

        // POST: SC_User/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "UserID,FirstName,MiddleName,LastName,"+
            "Email,Password,Phone,Address,UserTypeID")] SC_User user)
        {
            if (ModelState.IsValid)
            {
                db.Update(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: SC_User/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SC_User user = db.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: SC_User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
