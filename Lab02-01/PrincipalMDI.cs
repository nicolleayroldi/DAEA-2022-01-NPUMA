using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class PrincipalMDI : Form
    {
        public PrincipalMDI()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuManUsuarios_Click(object sender, EventArgs e)
        {
            MainUsuario frm = new MainUsuario();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
