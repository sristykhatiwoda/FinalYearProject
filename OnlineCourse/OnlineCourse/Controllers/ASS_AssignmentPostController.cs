using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineCourse.DapperObject;
using OnlineCourse.Models;
using System.Net;

namespace OnlineCourse.Controllers
{
    public class ASS_AssignmentPostController : Controller
    {
        private I_ASS_AssignmentPost db = new ASS_AssignmentPostDA();
        // GET: ASS_AssignmentPost
        public ActionResult Index()
        {
            var assignmentPost = db.AssignmentPost();
            return View(assignmentPost);
        }

        // GET: ASS_AssignmentPost/Details/5
        public ActionResult Details(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ASS_AssignmentPost assignmentPost = db.Find(id);
            if (assignmentPost == null)
            {
                return HttpNotFound();

            }
            return View(assignmentPost);
        }

        // GET: ASS_AssignmentPost/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ASS_AssignmentPost/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "AssignmentID,Questions,Deadline,"+
            "CourseID,UserID")]ASS_AssignmentPost assignmentPost)
        {
            if (ModelState.IsValid)
            {
                db.Add(assignmentPost);
                return RedirectToAction("Index");
            }
            return View(assignmentPost);
        }

        // GET: ASS_AssignmentPost/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ASS_AssignmentPost assignmentPost = db.Find(id);
            if (assignmentPost == null)
            {
                return HttpNotFound();
            }
            return View(assignmentPost);
        }

        // POST: ASS_AssignmentPost/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "AssignmentID,Questions,Deadline,CourseID,UserID")]ASS_AssignmentPost assignmentPost)
        {
            if (ModelState.IsValid)
            {
                db.Update(assignmentPost);
                return RedirectToAction("Index");
            }
            return View(assignmentPost);
        }

        // GET: ASS_AssignmentPost/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ASS_AssignmentPost assignmentPost = db.Find(id);
            if (assignmentPost == null)
            {
                return HttpNotFound();
            }
            return View(assignmentPost);
        }

        // POST: ASS_AssignmentPost/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            ASS_AssignmentPost assignmentPost = db.Find(id);
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
