﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineCourse.DapperObject;
using System.Net;
using OnlineCourse.Models;
using System.IO;

namespace OnlineCourse.Controllers
{
    public class COU_CourseContentController : Controller
    {

        private I_COU_CourseContent db = new COU_CourseContentDA();
        private I_SC_User dbUser = new SC_UserDA();
        private I_MS_Course dbCourse = new MS_CourseDA();
       
        // GET: COU_CourseContent
        public ActionResult Index()
        {
            var courseContent = db.CourseContent();
            return View(courseContent);
        }

        // GET: COU_CourseContent/Details/5
        public ActionResult Details(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COU_CourseContent courseContent = db.Find(id);
            if(courseContent==null)
            {
                return HttpNotFound();
            }
            return View();
        }

        // GET: COU_CourseContent/Create
        public ActionResult Create()
        {
            ViewBag.CourseID = new SelectList(dbCourse.Courses(), "CourseID", "CourseTitle");
            ViewBag.UserID = new SelectList(dbUser.Users(), "UserID", "FirstName");
            return View();
        }

        // POST: COU_CourseContent/Create
        [HttpPost]
        public ActionResult Create(COU_CourseContent courseContent,HttpPostedFileBase file1,HttpPostedFileBase file2)
        {
           if(ModelState.IsValid)
            {
                if (file1 != null)
                {
                    string fileName = file1.FileName;
                    string filePath = Path.Combine(Server.MapPath("~/CourseContent/Video"), Path.GetFileName(fileName));
                    file1.SaveAs(filePath);
                  courseContent.Video = fileName;   
                }
                if (file2 !=null)
                {
                    string newFile = file2.FileName;
                    string path = Path.Combine(Server.MapPath("~/CourseContent/File"), Path.GetFileName(newFile));
                    file2.SaveAs(path);
                    courseContent.Tutorials = newFile;
                }
                db.Add(courseContent);
                return RedirectToAction("Index");
            }
            return View(courseContent);
        }

        // GET: COU_CourseContent/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COU_CourseContent courseContent = db.Find(id);
            if(courseContent==null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseID = new SelectList(dbCourse.Courses(), "CourseID", "CourseTitle", courseContent.CourseID);
            ViewBag.UserID = new SelectList(dbUser.Users(), "UserID", "FirstName", courseContent.UserID);
            return View(courseContent);
        }

        // POST: COU_CourseContent/Edit/5
        [HttpPost]
        public ActionResult Edit(COU_CourseContent courseContent,HttpPostedFileBase file1,HttpPostedFileBase file2)
        {
            if(ModelState.IsValid)
            {
                if (file1 != null)
                {
                    string fileName = file1.FileName;
                    string filePath = Path.Combine(Server.MapPath("~/CourseContent/Video"), Path.GetFileName(fileName));
                    file1.SaveAs(filePath);
                    courseContent.Video = fileName;

                }
                if (file2 != null)
                {
                    string newFile = file2.FileName;
                    string path = Path.Combine(Server.MapPath("~/CourseContent/file"), Path.GetFileName(newFile));
                    file2.SaveAs(path);
                    courseContent.Tutorials = newFile;
                }
                db.Update(courseContent);
                return RedirectToAction("Index");
            }
            return View(courseContent);
        }

        // GET: COU_CourseContent/Delete/5
        public ActionResult Delete(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COU_CourseContent courseContent = db.Find(id);
            if (courseContent == null)
                return HttpNotFound();
            return View(courseContent);
        }

        // POST: COU_CourseContent/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            COU_CourseContent courseContent = db.Find(id);
            db.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult GetCourseContent(int? id)
        {
            if (id == null)
            {
                return  new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var courseContent = db.CourseContent().Where(a => a.CourseID == id).ToList();
            if(courseContent==null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseID = id;
            ViewBag.returnUrl = Request.Url.AbsoluteUri;
            return View(courseContent);
        }
    }
}
