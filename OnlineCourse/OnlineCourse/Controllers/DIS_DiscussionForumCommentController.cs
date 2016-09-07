using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineCourse.Models;
using OnlineCourse.DapperObject;
using System.IO;
using System.Net;

namespace OnlineCourse.Controllers
{
    public class DIS_DiscussionForumCommentController : Controller
    {
        private I_SC_User dbUser = new SC_UserDA();
        private I_STU_Student dbStudent = new STU_StudentDA();
        private I_DIS_DiscussionForumComment db = new DIS_DiscussionForumCommentDA();
        private I_DIS_DiscussionForum dbForum = new DIS_DiscussionForumDA();
        // GET: DIS_DiscussionForumComment
        public ActionResult Index()
        {
            var comments = db.DiscussionComments();
            return View(comments);
        }

        // GET: DIS_DiscussionForumComment/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DIS_DiscussionForumComment comments = db.Find(id);
            if (comments == null)
            {
                return HttpNotFound();
            }
            return View(comments);
        }

        // GET: DIS_DiscussionForumComment/Create
        public ActionResult Create()
        {
            ViewBag.UserID = new SelectList(dbUser.Users(), "UserID", "FirstName");
            ViewBag.StudentID = new SelectList(dbStudent.Students(), "StudentID", "FirstName");
            ViewBag.DiscussionForumID = new SelectList(dbForum.discussionForum(), "DiscussionForumID", "Title");
            return View();
        }

        // POST: DIS_DiscussionForumComment/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "CommentID,Date,Comment,UserID,DiscussionForumID,StudentID")]DIS_DiscussionForumComment comments)
        {
            if (ModelState.IsValid)
            {
                db.Add(comments);
                return RedirectToAction("Index");
            }
            ViewBag.UserID = new SelectList(dbUser.Users(), "UserID", "FirstName");
            ViewBag.StudentID = new SelectList(dbStudent.Students(), "StudentID", "FirstName" );
            ViewBag.DiscussionForumID = new SelectList(dbForum.discussionForum(), "DiscussionForumID", "Title");
            return View(comments);
        }

        // GET: DIS_DiscussionForumComment/Edit/5
        public ActionResult Edit(int ? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DIS_DiscussionForumComment comments = db.Find(id);
            if (comments == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserID = new SelectList(dbUser.Users(), "UserID", "FirstName", comments.UserID);
            ViewBag.StudentID = new SelectList(dbStudent.Students(), "StudentID", "FirstName" ,comments.StudentID);
            ViewBag.DiscussionForumID = new SelectList(dbForum.discussionForum(), "DiscussionForumID", "Title",comments.DiscussionForumID);
            return View(comments);
        }

        // POST: DIS_DiscussionForumComment/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, [Bind(Include = "CommentID,Date,Comment,UserID,DiscussionforumID,StudentID")]DIS_DiscussionForumComment comments)
        {
            if (ModelState.IsValid)
            {
                db.Update(comments);
                return RedirectToAction("Index");
            }
            return View(comments);
        }

        // GET: DIS_DiscussionForumComment/Delete/5
        public ActionResult Delete(int ? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DIS_DiscussionForumComment comments = db.Find(id);
            if (comments == null)
            {
                return HttpNotFound();
            }
            return View(comments);
        }

        // POST: DIS_DiscussionForumComment/Delete/5
        [HttpPost]
        public ActionResult Delete(int  id)
        {
            DIS_DiscussionForumComment comments = db.Find(id);
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
