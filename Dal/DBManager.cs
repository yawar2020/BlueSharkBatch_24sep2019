using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Settings;
using System.Data;
using System.Data.SqlClient;
namespace Dal
{
    public class DBManager
    {
        string ConnectionString=Setting.GetConnectionString();
        //GetEmployee

        public DataTable GetData(string SpName,Dictionary<string,string> dict) {

            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(SpName,con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            foreach (var item in dict)
            {
                cmd.Parameters.AddWithValue(item.Key,item.Value);
                //@Empname parametername
                //Chatterjee value
            }
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //insert & update
        public int SaveData(string SpName, Dictionary<string, string> dict)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(SpName, con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (var item in dict)
            {
                cmd.Parameters.AddWithValue(item.Key, item.Value);
            }
            if (dict.ContainsKey("@Empid"))
            {
                i = Convert.ToInt32(cmd.ExecuteNonQuery());

            }
            else
            {
                 i = Convert.ToInt32(cmd.ExecuteScalar());
            }
            con.Close();
            return i;
        }

       
    }
}
