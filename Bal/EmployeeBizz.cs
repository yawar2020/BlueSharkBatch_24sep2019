using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Bal
{
    public class EmployeeBizz
    {
        public DataTable GetEmployeeData()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            DBManager db = new DBManager();
           return db.GetData("sp_GetEmployee", dict);  
        }
        public int SaveDataDetails(string EmpName, int EmpSalary, int DeptId)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            DBManager db = new DBManager();
            dict.Add("@EmpName", EmpName);
            dict.Add("@EmpSalary", EmpSalary.ToString());
            dict.Add("@DeptId", DeptId.ToString());
            return db.SaveData("sp_SaveEmployeeDetails", dict);

        }


    }
    public class DepartmentBizz
    {
        public DataTable GetDepartmentData()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            DBManager db = new DBManager();
            return db.GetData("sp_GetDepartyment", dict);
        }
       
    }

}
