using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstApproach.Models;
using System.Data.Entity;
namespace CodeFirstApproach.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            List<EmployeeModel> employeedata = db.EmployeeModels.ToList();            
            return View(employeedata);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection frm)
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpName = frm["EmpName"];
            obj.EmpSalary = Convert.ToInt32(frm["EmpSalary"]);
            obj.DeptId = Convert.ToInt32(frm["DeptId"]);

            db.EmployeeModels.Add(obj);
           int i= db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            EmployeeModel obj = db.EmployeeModels.Find(id);
            return View(obj);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeModel obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            int i = db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            EmployeeModel obj = db.EmployeeModels.Find(id);
            return View(obj);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? Empid)
        {
            EmployeeModel obj = db.EmployeeModels.Find(Empid);
            db.EmployeeModels.Remove(obj);
            int i = db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}