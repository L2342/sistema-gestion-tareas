using System.Diagnostics;
using System.Text.RegularExpressions;

namespace sistema_gestion_tareas
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();


        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtComPassword.Text;
            string email = txtEmail.Text;
            string? role = cmbRole.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Todos los campos son obligatorios, incluido el rol", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Las contraseñas en los campos no coinciden", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password = "";
                confirmPassword = "";
                txtPassword.Focus();
            }
            else if (!EsContrasenaSegura(password))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, una letra mayúscula, una letra minúscula, un número y un carácter especial.", "contraseña invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (!EsCorreoValido(email))
            {
                MessageBox.Show("Por favor, ingresa un correo electrónico válido.", "Correo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Insertar Usuario Base de datos
                MessageBox.Show("Tu cuenta ha sido existosamente creada", "Registro existoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new frmLogin().Show();
                this.Hide();
            }
            //BACKEND

            // Crear instancia de la clase UsuariosBD
            UsuariosBD usuariosBD = new UsuariosBD();

            // Intentar registrar el usuario
            bool registroExitoso = usuariosBD.RegistrarUsuario(username, password, confirmPassword, email, role);

            if (registroExitoso)
            {
                //Debug.WriteLine("Usuario registrado correctamente.");
                MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar campos o redirigir a otra pantalla
                //button2_Click();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el usuario. El nombre de usuario o email ya podrían existir.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //BACKEND
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtEmail.Text = "";
            txtusername.Focus();
            cmbRole.SelectedIndex = 0;
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool EsContrasenaSegura(string password)
        {
            if (password.Length < 8)
                return false;
            if (!password.Any(char.IsUpper))
                return false;
            if (!password.Any(char.IsLower))
                return false;
            if (!password.Any(char.IsDigit))
                return false;
            if (!password.Any(ch => "!@#$%^&*()-_=+[]{}|;:'\",.<>?/`~".Contains(ch)))
                return false;

            return true;
        }
        private bool EsCorreoValido(string email)
        {
            // Expresión regular para validar el correo electrónico
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patron);
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
