namespace sistema_gestion_tareas
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();


        }
        // Conectar Base de datos

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
            string? role = cmbRole.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) ||
                string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Todos los campos son obligatorios, incluido el rol", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Las contrase�as en los campos no coinciden", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password = "";
                confirmPassword = "";
                txtPassword.Focus();
            } else if (!EsContrasenaSegura(password))
            {
                MessageBox.Show("La contrase�a debe tener al menos 8 caracteres, una letra may�scula, una letra min�scula, un n�mero y un car�cter especial.", "contrase�a invalida" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            }else
            {
                // Insertar Usuario Base de datos
                MessageBox.Show("Tu cuenta ha sido existosamente creada", "Registro existoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new frmLogin().Show();
                this.Hide();
            }
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
                txtPassword.PasswordChar = '�';
                txtComPassword.PasswordChar = '�';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
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
    }
}
