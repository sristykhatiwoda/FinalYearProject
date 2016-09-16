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
    public class NEW_NewsController : Controller
    {
        private I_NEW_News db = new NEW_NewsDA();
        private I_SC_User dbUser = new SC_UserDA();
        // GET: NEW_News
        public ActionResult Index()
        {
            var news = db.News(); 
            return View(news);
        }

        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NEW_News news = db.Find(id);
            if(news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }
        public ActionResult Create()
        {
            ViewBag.UserID = new SelectList(dbUser.Users(), "UserID", "FirstName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include ="NewsID,NewsDate,NewsTitle, NewsDescription, UserID")] NEW_News news)
        {
            if (ModelState.IsValid)
            {
                db.Add(news);

                return RedirectToAction("Index");
            }

            return View(news);
        }

        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NEW_News news = db.Find(id);
            if(news == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserID = new SelectList(dbUser.Users(), "UserID", "FirstName", news.UserID);
            return View(news);
        }


        [HttpPost]
        public ActionResult Edit([Bind(Include = "NewsID, NewsDate,NewsTitle, NewsDescription, UserID")] NEW_News news)
        {
            if (ModelState.IsValid)
            {

                db.Update(news);
                return RedirectToAction("Index");
            }
            return View(news);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NEW_News news = db.Find(id);
            if (news == null)
                return HttpNotFound();
            return View(news);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}