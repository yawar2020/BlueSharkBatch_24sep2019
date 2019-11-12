using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebApplication1.Models;

namespace WebApplication1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AddWcfService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AddWcfService.svc or AddWcfService.svc.cs at the Solution Explorer and start debugging.
    public class AddWcfService : IAddWcfService
    {
        public void DoWork()
        {
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public List<Employee> GetData()
        {
            SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Ganesh;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("Select * from EmployeeModels", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Employee> obj = new List<Employee>();
            foreach (DataRow dr in dt.Rows)
            {
                Employee objitem = new Employee();
                objitem.Empid = Convert.ToInt32(dr[0]);
                objitem.EmpName = Convert.ToString(dr[1]);
                objitem.EmpSalary = Convert.ToInt32(dr[2]);
                obj.Add(objitem);
            }
            return obj;
        }
    }
}
