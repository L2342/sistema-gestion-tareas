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
using MySql.Data.MySqlClient;

namespace sistema_gestion_tareas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtusername.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public int ObtenerIdUsuario(string username, string password)
        {
            int idUsuario = -1;
            string connectionString = "Server=localhost;Database=usuarios;Uid=root;Pwd=;Port=3306;SslMode=none;";
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string consulta = "SELECT id FROM profesores WHERE nombre = @username AND clave = @password";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        idUsuario = reader.GetInt32("id");
                    }
                    else
                    {
                        Debug.WriteLine("No se encontró el usuario con las credenciales proporcionadas.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener el ID del usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return idUsuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Inicio de Sesion fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear instancia de la clase UsuariosBD
            UsuariosBD usuariosBD = new UsuariosBD();

            // Intentar validar el login
            bool loginValido = usuariosBD.ValidarLogin(username, password, "Estudiante") || usuariosBD.ValidarLogin(username, password, "Profesor");

            if (loginValido)
            {
                // Obtener información del usuario
                DataTable datosUsuario = usuariosBD.ObtenerUsuario(username);

                if (datosUsuario != null && datosUsuario.Rows.Count > 0)
                {
                    Debug.WriteLine("Login hecho");
                    // Guardar datos de sesión (puedes usar variables estáticas, propiedades de aplicación, etc.)
                    int idUsuario = Convert.ToInt32(datosUsuario.Rows[0]["id"]);
                    string role = datosUsuario.Rows[0]["rol"].ToString();

                    // Mostrar el valor de idUsuario para depuración
                    Debug.WriteLine($"idUsuario: {idUsuario}");

                    // Llevar al dashboard dependiendo de su rol
                    if (role == "Estudiante")
                    {
                        dashBoard_Profesores dashboardEstudiantes = new dashBoard_Profesores();
                        dashboardEstudiantes.Show();
                        this.Hide();
                    }
                    else if (role == "Profesor")
                    {
                        dashboardProfesores dashboardProfesores = new dashboardProfesores();
                        dashboardProfesores.Show();
                        this.Hide();

                        // Redirigir al dashboard de profesores
                        frmAddEdit addEditForm = new frmAddEdit(idUsuario);
                        addEditForm.Show();
                    }
                }
            }
            else
            {
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



