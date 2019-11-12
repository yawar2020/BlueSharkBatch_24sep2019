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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAddWcfService" in both code and config file together.
    [ServiceContract]
    public interface IAddWcfService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        int Add(int a, int b);

        [OperationContract]
         List<Employee> GetData();
         
    }
}
