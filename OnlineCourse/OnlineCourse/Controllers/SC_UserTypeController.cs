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
    public class SC_UserTypeController : Controller
    {
        private I_SC_UserType db = new SC_UserTypeDA();
        // GET: SC_UserType
        public ActionResult Index()
        {
            var userType = db.UserTypes();
            return View(userType);
        }

        // GET: SC_UserType/Details/5
        public ActionResult Details(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SC_UserType userType = db.Find(id);
            if(userType==null)
            {
                return HttpNotFound();
            }
            return View(userType);
        }

        // GET: SC_UserType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SC_UserType/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "UserTypeID,Type")] SC_UserType userType)
        {
            if(ModelState.IsValid)
            {
                db.Add(userType);
                return RedirectToAction("Index");
            }
            return View(userType);
        }

        // GET: SC_UserType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SC_UserType userType = db.Find(id);
            if (userType == null)
            {
                return HttpNotFound();
            }
            return View(userType);
        }

        // POST: SC_UserType/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "UserTypeID,Type")] SC_UserType userType)
        {
           if(ModelState.IsValid)
            {
                db.Update(userType);
                return RedirectToAction("Index");
            }
            return View(userType);

        }

        // GET: SC_UserType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SC_UserType userType = db.Find(id);
            if (userType == null)
            {
                return HttpNotFound();
            }
            return View(userType);
        }

        // POST: SC_UserType/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
