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
            if (txtusername.Text == "" || txtPassword.Text == "" || txtComPassword.Text == "")
            {
                MessageBox.Show("Todos los campos deben ser completados", "Registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtComPassword.Text)
            {
                MessageBox.Show("Las contraseñas en los campos no coinciden", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }
            else
            {
                // Insertar Usuario Base de datos
                MessageBox.Show("Tu cuenta ha sido existosamente creada", "Registro existoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtusername.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";
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
        }
    }
}
