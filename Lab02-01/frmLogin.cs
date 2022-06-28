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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //PrincipalMDI principal = new PrincipalMDI();
            //principal.Show();
            //this.Hide();
            Dictionary<String, String> Usuarios = new Dictionary<string, string>();


            String usuario1 = "nicolle";
            String password1 = "1234";


            String usuario2 = "NIKIA";
            String password2 = "4321";

            String usuario3 = "Ayri";
            String password3 = "123456";


            Usuarios.Add(usuario1, password1);
            Usuarios.Add(usuario2, password2);
            Usuarios.Add(usuario3, password3);

            try
            {
                String usuarioEncontrado = Usuarios[txtUsuario.Text.ToString()];

                if (usuarioEncontrado.Equals(txtPassword.Text))
                {
                    PrincipalMDI principal = new PrincipalMDI();
                    principal.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Password Incorrecto");
                    txtUsuario.Clear();
                    txtPassword.Clear();
                    txtUsuario.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Usuario Incorrecto");
                txtUsuario.Clear();
                txtPassword.Clear();
                txtUsuario.Focus();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
