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
    public partial class Usuario : Form
    {
        SqlConnection conn;

        public Usuario(System.Data.SqlClient.SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

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
                        String sql = "SELECT * FROM tbl_usuario";
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
            String buscar = txtNombre.Text;

            try
            {

                if (!buscar.Equals(" "))
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        String sql = "SELECT * FROM tbl_usuario WHERE usuario_nombre = '" + buscar + "'";
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
                else
                {
                    MessageBox.Show("Ingrese el nombre del usuario a buscar");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el usuario: " + ex);

            }

        }

   
    }
}
