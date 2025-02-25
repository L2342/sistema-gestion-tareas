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
                MessageBox.Show("Todos los campos son obligatorios, incluido el rol.");
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Las contraseñas en los campos no coinciden", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password = "";
                confirmPassword = "";
                txtPassword.Focus();
            }
            else
            {
                // Insertar Usuario Base de datos
                MessageBox.Show("Tu cuenta ha sido existosamente creada", "Registro existoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                username = "";
                password = "";
                confirmPassword = "";
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
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
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
    }
}
