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
    public class DIS_DiscussionForumController : Controller
    {
        private I_DIS_DiscussionForum db = new DIS_DiscussionForumDA();
        private I_SC_User dbUser = new SC_UserDA();
        private I_STU_Student dbStudent = new STU_StudentDA();
        // GET: DIS_DiscussionForum
        public ActionResult Index()
        {
            var forum = db.discussionForum();
            return View(forum);
        }

        // GET: DIS_DiscussionForum/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DIS_DiscussionForum forum = db.Find(id);
            if(forum==null)
            {
                return HttpNotFound();
            }
            return View(forum);
        }

        // GET: DIS_DiscussionForum/Create
        public ActionResult Create()
        {
            ViewBag.UserID = new SelectList(dbUser.Users(), "UserID", "FirstName");
            ViewBag.StudentID=new SelectList(dbStudent.Students(),"StudentID","FirstName");
            return View();
        }

        // POST: DIS_DiscussionForum/Create
        [HttpPost]
        public ActionResult Create([ Bind(Include = "DiscussionForumID,Title,Description,Date,UserID,StudentID")]DIS_DiscussionForum forum)
        {
           if(ModelState.IsValid)
            {
                db.Add(forum);
                return RedirectToAction("Index");
            }
            ViewBag.UserID = new SelectList(dbUser.Users(), "UserID", "FirstName");
            ViewBag.StudentID = new SelectList(dbStudent.Students(), "StudentID", "FirstName" );
            return View(forum);
            
        }

        // GET: DIS_DiscussionForum/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DIS_DiscussionForum forum = db.Find(id);
            if(forum==null)
            {
                return HttpNotFound();
            }
            ViewBag.UserID = new SelectList(dbUser.Users(), "UserID", "FirstName" , forum.UserID);
            ViewBag.StudentID = new SelectList(dbStudent.Students(), "StudentID", "FirstName" ,forum.StudentID);
            return View(forum);
        }

        // POST: DIS_DiscussionForum/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include ="DisussionForumID,Title,Description,Date,UserID,StudentID")]DIS_DiscussionForum forum)
        {
           if(ModelState.IsValid)
            {
                db.Update(forum);
                return RedirectToAction("Index");
            }
           
            return View(forum);
            
        }

        // GET: DIS_DiscussionForum/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DIS_DiscussionForum forum = db.Find(id);
            if (forum==null)
            {
                return HttpNotFound();
            }
            return View(forum);
        }

        // POST: DIS_DiscussionForum/Delete/5
        [HttpPost]
        public ActionResult Delete(int  id)
        {
            DIS_DiscussionForum forum = db.Find(id);
            db.Delete(id);
             return RedirectToAction("Index");
            
        }
    }
}
