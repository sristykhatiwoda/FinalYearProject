using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineCourse.DapperObject;
using OnlineCourse.Models;
using System.Net;
using System.IO;

namespace OnlineCourse.Controllers
{
    public class ASS_AssignmentPostController : Controller
    {
        private I_ASS_AssignmentPost db = new ASS_AssignmentPostDA();
        private I_MS_Course dbCourse = new MS_CourseDA();
        private I_SC_User dbUser = new SC_UserDA();
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
            ViewBag.CourseID= new SelectList(dbCourse.Courses(),"CourseID", "CourseTitle");
            ViewBag.UserID = new SelectList(dbUser.Users(), "UserID", "FirstName");
            return View();
        }

        // POST: ASS_AssignmentPost/Create
        [HttpPost]
        public ActionResult Create(ASS_AssignmentPost assignmentPost,HttpPostedFileBase file1)
        {
            if (ModelState.IsValid)
            {
                if(file1!=null)
                {
                    string fileName = file1.FileName;
                    string filePath= Path.Combine(Server.MapPath("~/Assignments/AssignmentPost"), Path.GetFileName(fileName));
                    file1.SaveAs(filePath);
                    assignmentPost.Questions = fileName;
                }
                db.Add(assignmentPost);
                return RedirectToAction("Index");
            }
            ViewBag.CourseID = new SelectList(dbCourse.Courses(), "CourseID", "CourseTitle");
            ViewBag.UserID = new SelectList(dbUser.Users(), "UserID", "FirstName");

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
            ViewBag.CourseID = new SelectList(dbCourse.Courses(), "CourseID", "CourseTitle",assignmentPost.CourseID);
            ViewBag.UserID = new SelectList(dbUser.Users(), "UserID", "FirstName",assignmentPost.UserID);
            return View(assignmentPost);
        }

        // POST: ASS_AssignmentPost/Edit/5
        [HttpPost]
        public ActionResult Edit(ASS_AssignmentPost assignmentPost,HttpPostedFileBase file1)
        {
            if (ModelState.IsValid)
            {
                if (file1 != null)
                {
                    string fileName = file1.FileName;
                    string filePath = Path.Combine(Server.MapPath("~/Assignments/AssignmentPost"), Path.GetFileName(fileName));
                    file1.SaveAs(filePath);
                    assignmentPost.Questions = fileName;

                }
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
