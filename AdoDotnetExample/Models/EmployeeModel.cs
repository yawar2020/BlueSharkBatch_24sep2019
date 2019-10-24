using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Bal;
using System.Data;

namespace AdoDotnetExample.Models
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
    public class EmployeeDetail {

        public List<EmployeeModel> GetEmployeeData()
        {
            List<EmployeeModel> objList = new List<EmployeeModel>();
            EmployeeBizz obj = new EmployeeBizz();
            DataTable dt = new DataTable();
            dt = obj.GetEmployeeData();
            foreach (DataRow dr in dt.Rows)
            {
                EmployeeModel objitem = new EmployeeModel();
                objitem.Empid = Convert.ToInt32(dr[0]);
                objitem.EmpName = dr[1].ToString();
                objitem.EmpSalary = Convert.ToInt32(dr[2]);
                objitem.DeptId = Convert.ToInt32(dr[3]);
                objList.Add(objitem);
            }
            return objList;
        }
        public int SaveData(EmployeeModel Emp)
        {
            EmployeeBizz obj = new EmployeeBizz();
            int i = obj.SaveDataDetails(Emp.EmpName, Emp.EmpSalary, Emp.DeptId);
            return i;
        }
    }

    public class DepartmentDetail
    {

        public List<DepartmentModel> GetDepartmentData()
        {
            List<DepartmentModel> objList = new List<DepartmentModel>();
            DepartmentBizz obj = new DepartmentBizz();
            DataTable dt = new DataTable();
            dt = obj.GetDepartmentData();
            foreach (DataRow dr in dt.Rows)
            {
                DepartmentModel objitem = new DepartmentModel();
                
                objitem.DeptId = Convert.ToInt32(dr[0]);
                objitem.DeptName = (dr[1].ToString());

                objList.Add(objitem);
            }
            return objList;
        }

        
    }
}