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

namespace Lab06
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        DataSet ds = new DataSet();
        DataTable tablePerson = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String str = "Server=DESKTOP-I5RMC88\\MSSQLSERVERR; Database=School; Integrated Security = true;";
            conn = new SqlConnection(str);

            btnBuscar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnInsertar.Enabled = false;
        }

        void Listar()
        {
            String sql = "SELECT * FROM Person";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            ds.Clear();
            //LLenamos el dataset con una tabla llamada Person
            adapter.Fill(ds, "Person");

            //Asignamos esa tabla del dataset a un objeto Table
            //para trabajar directamente con el

            tablePerson = ds.Tables["Person"];

            dgvListado.DataSource = tablePerson;

            //Abilito el botones para las funciones
            btnBuscar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnInsertar.Enabled = true;


            dgvListado.Update();


            limpiarcampos();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("InsertPerson", conn);

            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50, "LastName");
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50, "FirstName");
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;


            //Creamos una fila nueva la cual insertamos en la BD
            //esta fila debe tener la estructura correspondiente

            DataRow fila = tablePerson.NewRow();
            fila["LastName"] = txtLastName.Text;
            fila["FirstName"] = txtFirstName.Text;

            fila["EnrollmentDate"] = txtEnrollmentDate.Value;

            //Una vez tenemos la fila, la agregamos a la tabla Person del dataset
            tablePerson.Rows.Add(fila);


            //Actualizamos el dataset con la tabla person
            adapter.Update(tablePerson);

            MessageBox.Show("Registro Insertado");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UpdatePerson", conn);

            //Add the parameters for the InsertComand
            cmd.Parameters.Add("@PersonID", SqlDbType.VarChar).SourceColumn = "PersonID";
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).SourceColumn = "LastName";
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).SourceColumn = "FirstName";
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;


            //Creamos un array de DataRow el cual almacenará la fila que coincida
            //con el resultado de la busqueda de PersonID
            //A cada campo de la fila, le asignamos el valor modificamos

            DataRow[] fila = tablePerson.Select("PersonID = '" + txtPersonID.Text + "'");
            fila[0]["LastName"] = txtLastName.Text;
            fila[0]["FirstName"] = txtFirstName.Text;
            fila[0]["HireDate"] = txtHireDate.Text;
            fila[0]["EnrollmentDate"] = txtEnrollmentDate.Text;


            //Actualizamos el dataset con la table modificada
            adapter.Update(tablePerson);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DeletePerson", conn);

            cmd.Parameters.Add("@PersonID", SqlDbType.VarChar).SourceColumn = "PersonID";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = cmd;
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;

            //Buscamos la fila a eliminar
            DataRow[] fila = tablePerson.Select("PersonID = '" + txtPersonID.Text + "'");



            try
            {

                // Initializes the variables to pass to the MessageBox.Show method.

                string message = "¿Estas seguro que Quieres Eliminar a esta persona?";
                string caption = "Eliminar Person";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(this, message, caption, buttons,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);

                if (result == DialogResult.Yes)
                {

                    // Closes the parent form.
                    fila[0].Delete();
                    adapter.Update(tablePerson);

                }
                if (result == DialogResult.No)
                {

                }



            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo Elimina porque el campo tiene relacion con otra tabla");
                Listar();

            }
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                txtPersonID.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtLastName.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                txtFirstName.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();

                String hireDate = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
                if (String.IsNullOrEmpty(hireDate))
                {

                    txtHireDate.Checked = false;
                }
                else
                {
                    txtHireDate.Text = hireDate;
                }

                String enrollmentDate = dgvListado.SelectedRows[0].Cells[4].Value.ToString();
                if (String.IsNullOrEmpty(enrollmentDate))
                {

                    txtEnrollmentDate.Checked = false;
                }
                else
                {
                    txtEnrollmentDate.Text = enrollmentDate;
                }

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPersonID.Text.Trim().Length > 0)
            {

                DataView dv = new DataView(tablePerson);
                dv.RowFilter = "PersonID = '" + txtPersonID.Text + "'";
                dgvListado.DataSource = dv;
                dgvListado.Update();

            }
            if (txtFirstName.Text.Trim().Length > 0)
            {

                DataView dv = new DataView(tablePerson);
                dv.RowFilter = "FirstName = '" + txtFirstName.Text + "'";
                dgvListado.DataSource = dv;
                dgvListado.Update();

            }
            if (txtLastName.Text.Trim().Length > 0)
            {

                DataView dv = new DataView(tablePerson);
                dv.RowFilter = "LastName = '" + txtLastName.Text + "'";
                dgvListado.DataSource = dv;
                dgvListado.Update();

            }

            if (txtLastName.Text.Trim().Length == 0 && txtFirstName.Text.Trim().Length == 0 && txtPersonID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese los valores segun el campo que quiere buscar.");
            }

            limpiarcampos();

        }


        void limpiarcampos()
        {

            txtPersonID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtHireDate.Checked = false;
            txtEnrollmentDate.Checked = false;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }
    }
}

