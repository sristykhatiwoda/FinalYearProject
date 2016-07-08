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
    public class QUIZ_QuizController : Controller
    {
        // GET: QUIZ_Quiz
        private I_QUIZ_Quiz db = new QUIZ_QuizDA();
        public ActionResult Index()
        {
            var quiz = db.Quizs();
            return View(quiz);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUIZ_Quiz quiz = db.Find(id);
            if (quiz == null)
            {
                return HttpNotFound();
            }
            return View(quiz);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "QuizID, QuizQuestion, Answer, Option1, Option2, Option3, Option4, CourseID, UserID")] QUIZ_Quiz quiz)
        {
            if (ModelState.IsValid)
            {
                db.Add(quiz);

                return RedirectToAction("Index");
            }

            return View(quiz);
        }

        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUIZ_Quiz quiz = db.Find(id);
            if(quiz == null)
            {
                return HttpNotFound();
            }
            return View(quiz);
        }

        [HttpPost]
        
        public ActionResult Edit([Bind(Include = "QuizID, QuizQuestion, Answer, Option1, Option2, Option3, Option4, CourseID, UserID")] QUIZ_Quiz quiz)
        {
            if (ModelState.IsValid)
            {
                db.Update(quiz);
                return RedirectToAction("Index");
            }
            return View(quiz);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUIZ_Quiz quiz = db.Find(id);
            if (quiz == null)
                return HttpNotFound();
            return View(quiz);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}