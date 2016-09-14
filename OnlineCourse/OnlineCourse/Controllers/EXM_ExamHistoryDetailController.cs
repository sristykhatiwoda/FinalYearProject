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
    public class EXM_ExamHistoryDetailController : Controller
    {
        private I_EXM_ExamHistoryDetail dbHistoryDetail = new EXM_ExamHistoryDetailDA();
        private I_QUIZ_Quiz dbQuiz = new QUIZ_QuizDA();
        private I_EXM_ExamHistory dbHistory=new EXM_ExamHistoryDA();
        // GET: EXM_ExamHistoryDetail
        public ActionResult Index()
        {
            var examHistoryDetail = dbHistoryDetail.ExamHistoryDetails();
            return View(examHistoryDetail);
        }

        // GET: EXM_ExamHistoryDetail/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
             EXM_ExamHistoryDetail examHistoryDetail = dbHistoryDetail.Find(id);
            if (examHistoryDetail == null)
            {
                return HttpNotFound();

            }
            return View(examHistoryDetail);
            
        }

        // GET: EXM_ExamHistoryDetail/Create
        public ActionResult Create()
        {
            ViewBag.QuiZID = new SelectList(dbQuiz.Quizs(), "QuizID", "QuizQuestion");
            ViewBag.ExamHistoryID = new SelectList(dbHistory.ExamHistories(), "ExamHistoryID", "ExamTakenDate");
            return View();
            
        }

        // POST: EXM_ExamHistoryDetail/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "ExamHistoryDetailID, QuizID,ExamHistoryID,SubmittedAnswer,Attempted")] EXM_ExamHistoryDetail examHistoryDetail)
        {
            if (ModelState.IsValid)
            {
                dbHistoryDetail.Add(examHistoryDetail);

                return RedirectToAction("Index");
            }
            ViewBag.QuiZID = new SelectList(dbQuiz.Quizs(), "QuizID", "QuizQuestion");
            ViewBag.ExamHistoryID = new SelectList(dbHistory.ExamHistories(), "ExamHistoryID", "ExamTakenDate");

            return View(examHistoryDetail);
        }

        // GET: EXM_ExamHistoryDetail/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EXM_ExamHistoryDetail examHistoryDetail = dbHistoryDetail.Find(id);
            if (examHistoryDetail == null)
            {
                return HttpNotFound();
            }

            ViewBag.QuiZID = new SelectList(dbQuiz.Quizs(), "QuizID", "QuizQuestion,", examHistoryDetail.QuizID);
            ViewBag.ExamHistoryID = new SelectList(dbHistory.ExamHistories(), "ExamHistoryID", "ExamTakenDate", examHistoryDetail.ExamHistoryID);
            return View(examHistoryDetail);
        }

        // POST: EXM_ExamHistoryDetail/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "ExamHistoryDetailID, QuizID,ExamHistoryID,SubmittedAnswer,Attempted")] EXM_ExamHistoryDetail examHistoryDetail)
        {
            if (ModelState.IsValid)
            {
                dbHistoryDetail.Update(examHistoryDetail);
                return RedirectToAction("Index");
            }
            ViewBag.QuiZID = new SelectList(dbQuiz.Quizs(), "QuizID", "QuizQuestion");
            ViewBag.ExamHistoryID = new SelectList(dbHistory.ExamHistories(), "ExamHistoryID", "ExamTakenDate");

            return View(examHistoryDetail);
        }

        // GET: EXM_ExamHistoryDetail/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EXM_ExamHistoryDetail examHistoryDetail = dbHistoryDetail.Find(id);
            if (examHistoryDetail == null)
                return HttpNotFound();
            return View(examHistoryDetail);
        }

        // POST: EXM_ExamHistoryDetail/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            dbHistoryDetail.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
