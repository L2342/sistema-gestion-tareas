using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            string username = txtusername.Text;
            string password = txtPassword.Text;

            //BACKEND
            // Crear instancia de la clase UsuariosBD
            UsuariosBD usuariosBD = new UsuariosBD();

            // Intentar validar el login
            bool loginValido = usuariosBD.ValidarLogin(username, password);

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Inicio de Sesion fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (loginValido)
            {
                // Obtener información del usuario
                DataTable datosUsuario = usuariosBD.ObtenerUsuario(username);

                if (datosUsuario != null && datosUsuario.Rows.Count > 0)
                {
                    Debug.WriteLine("Login hecho");
                    // Guardar datos de sesión (puedes usar variables estáticas, propiedades de aplicación, etc.)
                    int idUsuario = Convert.ToInt32(datosUsuario.Rows[0]["id"]);
                    string email = datosUsuario.Rows[0]["email"].ToString();
                    // string role = datosUsuario.Rows[0]["rol"].ToString();
                }
            }//BACKEND
            else
            {
                // usuario no identificado o datos incorrectos 
                MessageBox.Show("Usuario o Contraseña Invalidos, por favor intente nuevamente", "Inicio Sesión fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username = "";
                password = "";
                txtusername.Focus();
            }
            if (true) // usuario registrado
            {
                // llevar al dashboard dependiendo de su rol
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
