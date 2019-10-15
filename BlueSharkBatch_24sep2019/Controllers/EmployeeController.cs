using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlueSharkBatch_24sep2019.Models;
namespace BlueSharkBatch_24sep2019.Controllers
{

    public class EmployeeController : Controller
    {
        // GET: Employee

        public ActionResult GetData()
        {
            //Employee Model Information

            List<EmployeeModel> db = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Chaterjee";
            obj.EmpSalary = 25000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Sneha";
            obj1.EmpSalary = 35000;


            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Firoz";
            obj2.EmpSalary = 45000;

            db.Add(obj);
            db.Add(obj1);
            db.Add(obj2);

            //Department Information


            List<DepartmentModel> deptdb = new List<DepartmentModel>();

            DepartmentModel deptobj = new DepartmentModel();
            deptobj.DeptId = 1;
            deptobj.DeptName = "IT";

            DepartmentModel deptobj1 = new DepartmentModel();
            deptobj1.DeptId = 2;
            deptobj1.DeptName = "NetWork";

            deptdb.Add(deptobj);
            deptdb.Add(deptobj1);

          

            EmployeeDepartment empdept = new EmployeeDepartment();
            empdept.EmployeeModels = db;//Employees
            empdept.DepartmentModels = deptdb;//Departments

            return View(empdept);
        }

        public ActionResult GetDatabyId()
        {
            List<EmployeeModel> db = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Chaterjee";
            obj.EmpSalary = 25000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Sneha";
            obj1.EmpSalary = 35000;


            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Firoz";
            obj2.EmpSalary = 45000;

            db.Add(obj);
            db.Add(obj1);
            db.Add(obj2);


            var emp = db.Where(s => s.EmpId == 3).SingleOrDefault();

            return View(emp);
        }

    }
}