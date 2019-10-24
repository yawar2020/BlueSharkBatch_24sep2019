using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settings
{
    public static class Setting
    {
        public static string ConnectionString;

        public static string GetConnectionString() {
            ConnectionString = ConfigurationManager.ConnectionStrings["con"].ToString();
            return ConnectionString;
        }
    }
}
