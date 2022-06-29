using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class clsDAO
    {
        public SqlConnection conn;

        public clsDAO()
        {

            string str = "Server =DESKTOP-I5RMC88\\MSSQLSERVERR ; Database= School; Integrated Security=true;";
            conn = new SqlConnection(str);




            
        }
    }
}