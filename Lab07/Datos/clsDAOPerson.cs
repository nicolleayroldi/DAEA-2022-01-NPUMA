using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class clsDAOPerson : clsDAO
    {

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            conn.Open();

            String sql = "select * from Person";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);

            conn.Close();

            return dt;
        }



        public DataTable GetBuscar(string buscar)
        {
            DataTable dt = new DataTable();

            conn.Open();


            String sql = "";


            //Averiguo su el parametro buscar es numero o string
            int n;
            bool result = Int32.TryParse(buscar, out n);

            if (result)
            {
                int buscarCodigo = Int32.Parse(buscar);
                sql = "select * from Person where PersonID='" + buscarCodigo + "'";
            }
            else
            {
                sql = "select * from Person where LastName='" + buscar + "' OR FirstName = '" + buscar + "'";
            }

            try
            {
                Console.WriteLine("sql :: hola masna " + sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.ToString());
            }



            conn.Close();

            return dt;

        }
    }
}

