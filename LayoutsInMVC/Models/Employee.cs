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
        [Display(Name = "Employee Name")]
        [Required(ErrorMessage = "Empname Cannot be Empty")]
        public string EmpNames { get; set; }

        [Required(ErrorMessage = "Password Cannot be Empty")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password and Confirm PAssword Not Match")]
        public string ConfirmPassword { get; set; }

        [Range(20000, 50000, ErrorMessage = "Salary should be between 20000-50000")]
        public int EmpSalary { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(20,ErrorMessage ="Address Shuld not be more then 20")]
        public string Address { get; set; }
    }
}