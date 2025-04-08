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

        public int ObtenerIdUsuario(string username, string password, string role)
        {
            int idUsuario = -1;
            string connectionString = "Server=localhost;Database=usuarios;Uid=root;Pwd=;Port=3306;SslMode=none;";
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string consulta = role == "Profesor" ?
                        "SELECT id FROM profesores WHERE nombre = @username AND clave = @password" :
                        "SELECT id FROM estudiantes WHERE nombre = @username AND clave = @password";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        idUsuario = reader.GetInt32("id");
                        Debug.WriteLine($"Usuario encontrado: {idUsuario}");
                    }
                    else
                    {
                        Debug.WriteLine("No se encontró el usuario con las credenciales proporcionadas.");
                    }
                }
                catch (MySqlException ex) when (ex.Number == 1042)
                {
                    MessageBox.Show("No se puede conectar al servidor de base de datos.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MySqlException ex) when (ex.Number == 1045)
                {
                    MessageBox.Show("Error de autenticación con la base de datos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error de MySQL: {ex.Message}", "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Error al acceder a un objeto no inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show("Error al convertir datos entre tipos incompatibles.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
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
                bool loginValido = false;
                try
                {
                    loginValido = usuariosBD.ValidarLogin(username, password, "Estudiante") ||
                                 usuariosBD.ValidarLogin(username, password, "Profesor");
                }
                catch (MySqlException ex) when (ex.Number == 1042)
                {
                    MessageBox.Show("No se puede conectar al servidor de base de datos.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error en la base de datos: {ex.Message}", "Error de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (loginValido)
                {
                    // Obtener información del usuario
                    DataTable datosUsuario = null;
                    try
                    {
                        datosUsuario = usuariosBD.ObtenerUsuario(username);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Error al obtener datos del usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (datosUsuario != null && datosUsuario.Rows.Count > 0)
                    {
                        try
                        {
                            Debug.WriteLine("Login hecho");
                            // Guardar datos de sesión
                            int usuarioID = Convert.ToInt32(datosUsuario.Rows[0]["id"]);
                            string role = datosUsuario.Rows[0]["rol"].ToString();

                            Debug.WriteLine($"usuarioID: {usuarioID}");

                            // Guardar el ID del usuario en la sesión
                            if (role == "Estudiante")
                            {
                                Sesion.EstudianteID = usuarioID;
                            }
                            else if (role == "Profesor")
                            {
                                Sesion.ProfesorID = usuarioID;
                            }

                            // Llevar al dashboard dependiendo de su rol
                            if (role == "Estudiante")
                            {
                                dashBoard_Profesores dashboardEstudiantes = new dashBoard_Profesores(usuarioID);
                                dashboardEstudiantes.Show();
                                this.Hide();
                            }
                            else if (role == "Profesor")
                            {
                                dashboardProfesores dashboardProfesores = new dashboardProfesores();
                                dashboardProfesores.Show();
                                this.Hide();
                            }
                        }
                        catch (InvalidCastException ex)
                        {
                            MessageBox.Show("Error al procesar los datos del usuario: formato incompatible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        catch (NullReferenceException ex)
                        {
                            MessageBox.Show("Error al acceder a los datos del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo obtener la información del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                // Captura general para cualquier excepción no manejada específicamente
                MessageBox.Show($"Ha ocurrido un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

