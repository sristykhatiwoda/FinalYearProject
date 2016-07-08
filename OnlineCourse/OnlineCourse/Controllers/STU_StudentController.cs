using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineCourse.DapperObject;
using OnlineCourse.Models;
using System.IO;
using System.Net;

namespace OnlineCourse.Controllers
{
    public class STU_StudentController : Controller
    {
        private I_STU_Student db = new STU_StudentDA();
        // GET: STU_Student
        public ActionResult Index()
        {
            var students = db.Students();
            return View(students);
        }

        // GET: STU_Student/Details/5
        public ActionResult Details(int? id)
        {   
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STU_Student student = db.Find(id);
            if (student == null)
            {
                return HttpNotFound();
                
            }
            return View(student);
        }

        // GET: STU_Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: STU_Student/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "StudentID,FirstName,MiddleName,LastName,Email,"+
            "Password,FacultyID,BatchID,SemesterID")]STU_Student student)
        {
            if (ModelState.IsValid)
            {
                db.Add(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: STU_Student/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STU_Student student = db.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: STU_Student/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "StudentID,FirstName,MiddleName,LastName,Email,"+
            "Password,FacultyID,BatchID,SemesterID")]STU_Student student)
        {
           if(ModelState.IsValid)
            {
                db.Update(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: STU_Student/Delete/5
        public ActionResult Delete(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STU_Student student = db.Find(id);
            if(student==null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: STU_Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            STU_Student student = db.Find(id);
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
