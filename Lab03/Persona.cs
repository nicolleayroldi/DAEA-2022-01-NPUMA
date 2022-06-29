using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab03
{
    public partial class Persona : Form
    {
        SqlConnection conn;

        public Persona(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }


        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                {
                    MessageBox.Show("La conexion es nula");
                }
                else
                {

                    if (conn.State == ConnectionState.Open)
                    {
                        String sql = "SELECT * FROM Person";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvListado.DataSource = dt;
                        dgvListado.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("La conexión esta cerrada");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en listar los usuarios: " + ex);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    String FirstName = txtNombre.Text;

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "BuscarPersonalNombre";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@FirstName";
                    param.Value = FirstName;

                    cmd.Parameters.Add(param);

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvListado.DataSource = dt;
                    dgvListado.Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("La Conexion esta cerradda", ex.ToString());
                }
            }
    }
}
}
