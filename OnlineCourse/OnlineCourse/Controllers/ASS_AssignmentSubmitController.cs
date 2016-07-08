﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineCourse.Models;
using System.Net;
using OnlineCourse.DapperObject;

namespace OnlineCourse.Controllers
{
    public class ASS_AssignmentSubmitController : Controller
    {
        private I_ASS_AssignmentSubmit db = new ASS_AssignmentSubmitDA();
        // GET: ASS_AssignmentSubmit
        public ActionResult Index()
        {
            var assignmentSubmit = db.AssignmentSubmits();
            return View(assignmentSubmit);
        }

        // GET: ASS_AssignmentSubmit/Details/5
        public ActionResult Details(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ASS_AssignmentSubmit assignmentSubmit = db.Find(id);
            if(assignmentSubmit==null)
            {
                return HttpNotFound();
            }
            return View(assignmentSubmit);
        }

        // GET: ASS_AssignmentSubmit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ASS_AssignmentSubmit/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "SubmitAssignmentID,SubmissionDate,Answer,Point," +
            "Remarks,AssignmentID,StudentID")]ASS_AssignmentSubmit assignmentSubmit)
        {
            if(ModelState.IsValid)
            {
                db.Add(assignmentSubmit);
                return RedirectToAction("Index");
            }
            return View(assignmentSubmit);
        }

        // GET: ASS_AssignmentSubmit/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ASS_AssignmentSubmit assignmentSubmit = db.Find(id);
            if (assignmentSubmit == null)
            {
                return HttpNotFound();
            }
            return View(assignmentSubmit);
        }
    

        // POST: ASS_AssignmentSubmit/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "SubmitAssignmentID,SubmissionDate,Answer,Point," +
            "Remarks,AssignmentID,StudentID")]ASS_AssignmentSubmit assignmentSubmit)
        {
            if(ModelState.IsValid)
            {
                db.Update(assignmentSubmit);
                return RedirectToAction("Index");
            }
            return View(assignmentSubmit);
        }

        // GET: ASS_AssignmentSubmit/Delete/5
        public ActionResult Delete(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ASS_AssignmentSubmit assignmentSubmit = db.Find(id);
            if (assignmentSubmit == null)
            {
                return HttpNotFound();
            }
            return View(assignmentSubmit);
        }

        // POST: ASS_AssignmentSubmit/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}