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

namespace Lab05
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            String str = "Server=DESKTOP-I5RMC88\\MSSQLSERVERR; Database=School; Integrated Security = true;";
            conn = new SqlConnection(str);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            conn.Open();

            String sql = "select * from Person";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvListado.DataSource = dt;
            dgvListado.Refresh();
            conn.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sp = "InsertPerson";
            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@HireDate", txtHireDate.Value);
            cmd.Parameters.AddWithValue("@EnrollmentDate", txtEnrollmentDate.Value);

            int codigo = Convert.ToInt32(cmd.ExecuteScalar());
            MessageBox.Show("Se ha registrado nueva persona con el codigo : " + codigo);
            conn.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sq = "UpdatePerson";

            SqlCommand cmd = new SqlCommand(sq, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonID", txtPersonID.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@HireDate", txtHireDate.Value);
            cmd.Parameters.AddWithValue("@EnrollmentDate", txtEnrollmentDate.Value);

            int resultado = cmd.ExecuteNonQuery();
            if (resultado > 0)
            {
                MessageBox.Show("Se ha modificado el registro correctamente");
            }

            conn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sq = "DeletePerson";

            SqlCommand cmd = new SqlCommand(sq, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            int ID = 0;
            bool INT = Int32.TryParse(txtPersonID.Text,out ID);
            cmd.Parameters.AddWithValue("@PersonID", ID );

            try
            {
                int resultado = cmd.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Se ha eliminado el registro correctamente");
                }

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al Eliminar : " + ex.ToString());
            }
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                txtPersonID.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtLastName.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                txtFirstName.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();
                txtHireDate.Text = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
                txtEnrollmentDate.Text = dgvListado.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (txtFirstName.TextLength > 0)
            {
                String sqN = "BuscarPersonalNombre";

                SqlCommand cmd = new SqlCommand(sqN, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);

                try
                {

                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dgvListado.DataSource = dt;
                    dgvListado.Refresh();
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al Eliminar : " + ex.ToString());
                }

            }

            if (txtPersonID.TextLength > 0)
            {
                String sqN = "BuscarPersonaCodigo";

                SqlCommand cmd = new SqlCommand(sqN, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PersonID", Int32.Parse(txtPersonID.Text));

                try
                {

                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dgvListado.DataSource = dt;
                    dgvListado.Refresh();
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al Eliminar : " + ex.ToString());
                }
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPersonID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtHireDate.Text = "";
            txtEnrollmentDate.Text = "";
        }
    }
}
