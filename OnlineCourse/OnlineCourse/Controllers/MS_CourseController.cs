using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using OnlineCourse.DapperObject;
using OnlineCourse.Models;
using System.Net;

namespace OnlineCourse.Controllers
{
    public class MS_CourseController : Controller
    {
        private I_MS_Course db = new MS_CourseDA();
        // GET: MS_Course
        public ActionResult Index()
        {
            var courses = db.Courses();

            return View(courses);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MS_Course course = db.Find(id);
            if (course == null)

            {
                return HttpNotFound();
            }
            return View(course);
        }

        // GET: /MS_Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /MS_Course/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CourseID,CourseTitle")] MS_Course course)
        {
            if (ModelState.IsValid)
            {
                db.Add(course);

                return RedirectToAction("Index");
            }

            return View(course);
        }

        // GET: /MS_Course/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MS_Course course = db.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: /Category/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseID,CourseTitle")] MS_Course course)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(category).State = EntityState.Modified;
                db.Update(course);
                return RedirectToAction("Index");
            }
            return View(course);
        }



        // GET: /MS_Course/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MS_Course course= db.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }


        // POST: /MS_Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            
            db.Delete(id);
            return RedirectToAction("Index");
        }




    }
}