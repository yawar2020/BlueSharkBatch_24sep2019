using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstApproach.Models;
namespace CodeFirstApproach.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            var employeedata = from s in db.EmployeeModels
                               join d in db.DepartmentModeles
                               on s.DeptId equals d.DeptId
                               select new Empdept
                               {
                                  Empid= s.Empid,
                                  EmpName=s.EmpName,
                                  EmpSalary=s.EmpSalary,
                                  DeptName=d.DeptName
                               };
                              
            return View(employeedata);
        }
    }
}