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
    public class EXM_ExamHistoryController : Controller
    {
        private I_EXM_ExamHistory dbHistory = new EXM_ExamHistoryDA();
        private I_STU_Student dbStudent = new STU_StudentDA();
        // GET: EXM_ExamHistory
        public ActionResult Index()
        {
            var examHistory = dbHistory.ExamHistories();
            return View(examHistory);
        }

        // GET: EXM_ExamHistory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EXM_ExamHistory examHistory = dbHistory.Find(id);
            if (examHistory == null)
            {
                return HttpNotFound();

            }
            return View(examHistory);
        }

        // GET: EXM_ExamHistory/Create
        public ActionResult Create()
        {
            ViewBag.StudentID = new SelectList(dbStudent.Students(), "StudentID", "FirstName");
            return View();
        }

        // POST: EXM_ExamHistory/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "ExamHistoryID, StudentID,ExamTakenDate,ExamStartTime,ExamCompletedTime,Score")] EXM_ExamHistory examHistory)
        {
            if (ModelState.IsValid)
            {
                dbHistory.Add(examHistory);

                return RedirectToAction("Index");
            }
            ViewBag.StudentID = new SelectList(dbStudent.Students(), "StudentID", "FirstName");
           
            return View(examHistory);
        }

        // GET: EXM_ExamHistory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EXM_ExamHistory examHistory = dbHistory.Find(id);
            if (examHistory == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentID = new SelectList(dbStudent.Students(), "StudentID", "FirstName", examHistory.StudentID);
           
            return View(examHistory);
        }

        // POST: EXM_ExamHistory/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "ExamHistoryID, StudentID,ExamTakenDate,ExamStartTime,ExamCompletedTime,Score")] EXM_ExamHistory examHistory)
        {
            if (ModelState.IsValid)
            {
                dbHistory.Update(examHistory);
                return RedirectToAction("Index");
            }
            ViewBag.StudentID = new SelectList(dbStudent.Students(), "StudentID", "FirstName");
            
            return View(examHistory);
        }

        // GET: EXM_ExamHistory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EXM_ExamHistory examHistory = dbHistory.Find(id);
            if ( examHistory== null)
                return HttpNotFound();
            return View(examHistory);
        }

        // POST: EXM_ExamHistory/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            dbHistory.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
