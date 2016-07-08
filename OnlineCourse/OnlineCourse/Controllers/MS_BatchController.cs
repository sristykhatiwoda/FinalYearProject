using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineCourse.Models;
using OnlineCourse.DapperObject;
using System.Net;

namespace OnlineCourse.Controllers
{
    public class MS_BatchController : Controller
    {
        private I_MS_Batch db = new MS_BatchDA();
        // GET: MS_Batch
        public ActionResult Index()
        {
            var batches = db.Batches();
            return View(batches);
        }

        // GET: MS_Batch/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MS_Batch batch= db.Find(id);
            if (batch == null)

            {
                return HttpNotFound();
            }
            return View(batch);
        }

        // GET: MS_Batch/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MS_Batch/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "BatchID,Batch")] MS_Batch batch)
        {
            if (ModelState.IsValid)
            {
                db.Add(batch);

                return RedirectToAction("Index");
            }

            db.Add(batch);
            return View(batch);
        }

        // GET: MS_Batch/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MS_Batch batch = db.Find(id);
            if (batch == null)

            {
                return HttpNotFound();
            }
            return View(batch);
        }

        // POST: MS_Batch/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "BatchID,Batch")] MS_Batch batch)
        {
            if (ModelState.IsValid)
            {
                db.Update(batch);

                return RedirectToAction("Index");
            }

            return View(batch);
        }

        // GET: MS_Batch/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           MS_Batch batch = db.Find(id);
            if (batch == null)

            {
                return HttpNotFound();
            }
            return View(batch);
        }

        // POST: MS_Batch/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
