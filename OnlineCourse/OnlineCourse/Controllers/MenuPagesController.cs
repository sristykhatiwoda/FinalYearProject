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
    public class MenuPagesController : Controller
    {
        private I_MenuPages db = new MenuPagesDA();
        // GET: MenuPages
        public ActionResult Index()
        {
            var menuPage = db.MenuPages();
            return View(menuPage);
           
        }

        // GET: MenuPages/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuPages menuPage = db.Find(id);
            if (menuPage == null)
            {
                return HttpNotFound();
            }
            return View(menuPage);
            
        }

        // GET: MenuPages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuPages/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "MenuPageId,MenuTitle,PageContent,DisplayOrder,IsActive")] MenuPages menuPage)
        {
            if (ModelState.IsValid)
            {
                db.Add(menuPage);
                return RedirectToAction("Index");
            }

            return View(menuPage);
        }

        // GET: MenuPages/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuPages menuPage = db.Find(id);
            if (menuPage == null)
            {
                return HttpNotFound();
            }
            return View(menuPage);
        }

        // POST: MenuPages/Edit/5
        [HttpPost]
        public ActionResult Edit( [Bind(Include = "MenuPageId,MenuTitle,PageContent,DisplayOrder,IsActive")] MenuPages menuPage)
        {
            if (ModelState.IsValid)
            {
                // db.Add(menuPage).State = EntityState.Modified;
                // db.SaveChanges();
                db.Update(menuPage);
                return RedirectToAction("Index");
            }
            return View(menuPage);
        }

        // GET: MenuPages/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuPages menuPage = db.Find(id);
            if (menuPage == null)
            {
                return HttpNotFound();
            }
            return View(menuPage);
        }

        // POST: MenuPages/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            MenuPages menuPage = db.Find(id);
            // db.MenuPages.Remove(menuPage);
            //db.SaveChanges();
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
