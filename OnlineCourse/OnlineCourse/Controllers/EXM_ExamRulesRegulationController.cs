using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineCourse.Models;
using OnlineCourse.DapperObject;
using System.Net;
using System.IO;

namespace OnlineCourse.Controllers
{
    public class EXM_ExamRulesRegulationController : Controller
    {
        private I_EXM_ExamRulesRegulation db = new EXM_ExamRulesRegulationDA();
        // GET: EXM_ExamRulesRegulation
        public ActionResult Index()
        {
            var examRulesRegulation = db.ExamRulesRegulations();
            return View(examRulesRegulation);
        }

        // GET: EXM_ExamRulesRegulation/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EXM_ExamRulesRegulation examRulesRegulation = db.Find(id);
            if (examRulesRegulation == null)
            {
                return HttpNotFound();

            }
            return View(examRulesRegulation);
        }

        // GET: EXM_ExamRulesRegulation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EXM_ExamRulesRegulation/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "ExamRulesRegulationID,ExamRulesRegulationText")] EXM_ExamRulesRegulation examRulesRegulation)
        {
            if (ModelState.IsValid)
            {
                db.Add(examRulesRegulation);

                return RedirectToAction("Index");
            }

            return View(examRulesRegulation);

        }

        // GET: EXM_ExamRulesRegulation/Edit/5
        public ActionResult Edit(int ? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           EXM_ExamRulesRegulation examRulesRegulation = db.Find(id);
            if (examRulesRegulation == null)
            {
                return HttpNotFound();
            }
            return View(examRulesRegulation);
        }

        // POST: EXM_ExamRulesRegulation/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "ExamRulesRegulationID,ExamRulesRegulationText")] EXM_ExamRulesRegulation examRulesRegulation)
        {
            if (ModelState.IsValid)
            {
                
                db.Update(examRulesRegulation);
                return RedirectToAction("Index");
            }
            return View(examRulesRegulation);
        }
    

        // GET: EXM_ExamRulesRegulation/Delete/5
        public ActionResult Delete(int ? id)
        {
        if (id == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
        EXM_ExamRulesRegulation examRulesRegulation = db.Find(id);
        if (examRulesRegulation== null)
        {
            return HttpNotFound();
        }
        return View(examRulesRegulation);
    }

        // POST: EXM_ExamRulesRegulation/Delete/5
     
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            db.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
