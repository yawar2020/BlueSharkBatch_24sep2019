using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdoDotnetExample.Models;
namespace AdoDotnetExample.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        EmployeeDetail db = new Models.EmployeeDetail();

        public ActionResult Index()
        {

            return View(db.GetEmployeeData());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int i = db.SaveData(emp);


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
        public ActionResult Edit(int?id)
        {
            EmployeeModel emp =db.GetEmployeeDatabyid(id); 
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            int i = db.UpdateData(emp);


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
        public ActionResult Delete(int? id) {
            EmployeeModel emp = db.GetEmployeeDatabyid(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            int i = db.DeleteEmpById(id);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Department()
        {
            DepartmentDetail db = new Models.DepartmentDetail();

            return View(db.GetDepartmentData());
        }

        public ActionResult GetAccessService() {
            ServiceReference1.MyWebServiceSoapClient obj = new ServiceReference1.MyWebServiceSoapClient();
            ViewBag.Add = obj.Add(16, 20);
            return View();
        }
        public ActionResult GetWcfAccessService()
        {
            ServiceReference2.GetDataServiceClient obj = new ServiceReference2.GetDataServiceClient();
           
            return View(obj.GetEmployeeData().ToList());
        }
    }
}