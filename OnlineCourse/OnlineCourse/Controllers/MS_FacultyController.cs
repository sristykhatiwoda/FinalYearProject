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
    public class MS_FacultyController : Controller
    {
        private I_MS_Faculty db = new MS_FacultyDA();

        // GET: MS_Faculty
        public ActionResult Index()
        {
            var faculties = db.Faculties();
            return View(faculties);
        }

        // GET: MS_Faculty/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MS_Faculty faculty = db.Find(id);
            if (faculty == null)

            {
                return HttpNotFound();
            }
            return View(faculty);
        }

        // GET: MS_Faculty/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MS_Faculty/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "FacultyID,FacultyTitle")] MS_Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                db.Add(faculty);

                return RedirectToAction("Index");
            }

            return View(faculty);
        }

        // GET: MS_Faculty/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MS_Faculty faculty = db.Find(id);
            if (faculty == null)

            {
                return HttpNotFound();
            }
            return View(faculty);

        }

        // POST: MS_Faculty/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "FacultyID,FacultyTitle")] MS_Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                db.Update(faculty);

                return RedirectToAction("Index");
            }

            return View(faculty);

        }

        // GET: MS_Faculty/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MS_Faculty faculty = db.Find(id);
            if (faculty == null)

            {
                return HttpNotFound();
            }
            return View(faculty);
        }

        // POST: MS_Faculty/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
