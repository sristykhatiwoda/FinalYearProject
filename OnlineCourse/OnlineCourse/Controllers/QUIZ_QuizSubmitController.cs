using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using OnlineCourse.Models;
using OnlineCourse.DapperObject;

namespace OnlineCourse.Controllers
{
    public class QUIZ_QuizSubmitController : Controller
    {
        private I_QUIZ_QuizSubmit db = new Quiz_QuizSubmitDA();
        // GET: QUIZ_QuizSubmit
        public ActionResult Index()
        {
            var quizSubmit = db.QuizSubmits();
            return View(quizSubmit);
        }

        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUIZ_QuizSubmit quizSumit = db.Find(id);
            if(quizSumit == null)
            {
                return HttpNotFound();
            }
            return View(quizSumit);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind (Include = "QuizSubmitID, Answer, QuizPoint, StudentID, QuizID")] QUIZ_QuizSubmit quizSubmit)
        {
            if (ModelState.IsValid)
            {
                db.Add(quizSubmit);
                return RedirectToAction("Index");
            }
            return View(quizSubmit);
        }

        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUIZ_QuizSubmit quizSubmit = db.Find(id);
            if(quizSubmit == null)
            {
                return HttpNotFound();
            }
            return View(quizSubmit);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "QuizSubmitID, Answer, QuizPoint, StudentID, QuizID")] QUIZ_QuizSubmit quizSubmit)
        {
            if (ModelState.IsValid)
            {
                db.Update(quizSubmit);
                return RedirectToAction("Index");
            }
            return View(quizSubmit);
        }

        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUIZ_QuizSubmit quizSubmit = db.Find(id);
            if(quizSubmit == null)
            {
                return HttpNotFound();
            }
            return View(quizSubmit);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");

        }
    }
}