using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueSharkBatch_24sep2019.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
    }

    public class DepartmentModel
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }
    public class EmployeeDepartment
    {
        public List<EmployeeModel> EmployeeModels { get; set; }
        public List<DepartmentModel>DepartmentModels { get; set; }
    }
}