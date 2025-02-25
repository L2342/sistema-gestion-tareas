using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestion_tareas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtusername.Focus();
        }


        // pendiente conexion  base de datos

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // validacion base de datos

            if (true) // usuario registrado
            {
                // llevar al dashboard dependiendo de su rol
            }
            else
            {
                // usuario no identificado o datos incorrectos 
                MessageBox.Show("Usuario o Contraseña Invalidos, por favor intente nuevamente", "Inicio Sesión fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Text = "";
                txtPassword.Text = "";
                txtusername.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtPassword.Text = "";
            txtusername.Focus();
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }
    }
}
