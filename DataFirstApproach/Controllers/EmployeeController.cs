using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataFirstApproach.Models;

namespace DataFirstApproach.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeEntities db = new EmployeeEntities();

        // GET: Employee
        public ActionResult Index()
        {
            return View(db.employeeDetails.ToList());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            employeeDetail employeeDetail = db.employeeDetails.Find(id);
            if (employeeDetail == null)
            {
                return HttpNotFound();
            }
            return View(employeeDetail);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "empid,empname,empsalary")] employeeDetail employeeDetail)
        {
            if (ModelState.IsValid)
            {
                db.employeeDetails.Add(employeeDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeDetail);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            employeeDetail employeeDetail = db.employeeDetails.Find(id);
            if (employeeDetail == null)
            {
                return HttpNotFound();
            }
            return View(employeeDetail);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "empid,empname,empsalary")] employeeDetail employeeDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeDetail);
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            employeeDetail employeeDetail = db.employeeDetails.Find(id);
            if (employeeDetail == null)
            {
                return HttpNotFound();
            }
            return View(employeeDetail);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            employeeDetail employeeDetail = db.employeeDetails.Find(id);
            db.employeeDetails.Remove(employeeDetail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
