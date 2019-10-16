using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Empid { get; set; }
        public string EmpName { get; set; }

        public int EmpSalary { get; set; }
        public int DeptId { get; set; }
    }

    public class DepartmentModel
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }

    public class Empdept
    {
        public int Empid { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
        public string DeptName { get; set; }

    }
}