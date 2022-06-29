using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void Listar()
        {
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.GetAll();

            dgDatos.DataSource = dt;
            dgDatos.Refresh();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            string txtBuscar = txtSearch.Text.Trim();

            try
            {
                dt = np.GetBuscar(txtBuscar);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en el form : " + ex.ToString());
            }


            dgDatos.DataSource = dt;
            dgDatos.Refresh();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
