using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LayoutsInMVC.Models
{
    public class Employee
    {
        public int Empid { get; set; }
        [Display(Name ="Employee Name")]
        public string EmpNames { get; set; }
        public int EmpSalary { get; set; }
    }
}