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
    public class MS_SemesterController : Controller
    {
        private I_MS_Semester db = new MS_SemesterDA();
        // GET: MS_Semester
        public ActionResult Index()
        {
            var semester = db.Semesters();
            return View(semester);
        }

        // GET: MS_Semester/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MS_Semester semester= db.Find(id);
            if (semester == null)

            {
                return HttpNotFound();
            }
            return View(semester);
        }

        // GET: MS_Semester/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MS_Semester/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "SemesterID,SemesterTitle")] MS_Semester semester)
        {
            if (ModelState.IsValid)
            {
                db.Add(semester);

                return RedirectToAction("Index");
            }

            return View(semester);
        }

        // GET: MS_Semester/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MS_Semester semester = db.Find(id);
            if (semester == null)

            {
                return HttpNotFound();
            }
            return View(semester);
        }

        // POST: MS_Semester/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "SemesterID,SemesterTitle")] MS_Semester semester)
        {
            if (ModelState.IsValid)
            {
                db.Update(semester);

                return RedirectToAction("Index");
            }

            return View(semester);
        }

        // GET: MS_Semester/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MS_Semester semester = db.Find(id);
            if (semester == null)

            {
                return HttpNotFound();
            }
            return View(semester);
        }

        // POST: MS_Semester/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
