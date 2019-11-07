using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServiceExample.Model;

namespace WCFServiceExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GetDataService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GetDataService.svc or GetDataService.svc.cs at the Solution Explorer and start debugging.
    public class GetDataService : IGetDataService
    {
        public void DoWork()
        {
        }

        public static DataTable GetData()
        {

            SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Ganesh;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("sp_GetEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
             
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public  List<Employee> GetEmployeeData()
        {
            List<Employee> objList = new List<Employee>();
           
            DataTable dt = GetData();

            foreach (DataRow dr in dt.Rows)
            {
                Employee objitem = new Employee();
                objitem.EmpId = Convert.ToInt32(dr[0]);
                objitem.EmpName = dr[1].ToString();
                objitem.EmpSalary = Convert.ToInt32(dr[2]);
               
                objList.Add(objitem);
            }
            return objList;
        }
    }
}
