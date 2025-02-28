using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema_gestion_tareas
{
    public partial class frmAddEdit : Form
    {
        private int profesorID;
        private int? tareaID;
        private ConexionDB conexionDB;

        public frmAddEdit()
        {
            InitializeComponent();
        }

        public frmAddEdit(int profesorID)
        {
            InitializeComponent();
            this.profesorID = profesorID;
            conexionDB = new ConexionDB();

            // Mostrar el valor de profesorID para depuración
            Debug.WriteLine("Usuario ID recibido: " + profesorID);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("El título es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("La descripción es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtpFechaEntrega.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha de entrega no puede ser pasada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxAsignaturas.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar una asignatura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Debes asignar al menos un grupo de estudiantes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar el valor de profesorID para depuración
            Debug.WriteLine($"profesorID: {profesorID}");

            // Conectar a la base de datos y guardar la información
            string connectionString = "Server=localhost;Database=usuarios;Uid=root;Pwd=;Port=3306;SslMode=none;";
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string consulta = "INSERT INTO tareas (titulo, descripcion, fecha_entrega, grupo_asignado, profesor_id, materia) " +
                                      "VALUES (@titulo, @descripcion, @fechaEntrega, @grupoAsignado, @profesorID, @materia)";

                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@titulo", txtTitulo.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@fechaEntrega", dtpFechaEntrega.Value);
                    cmd.Parameters.AddWithValue("@grupoAsignado", comboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@profesorID", profesorID);
                    cmd.Parameters.AddWithValue("@materia", cbxAsignaturas.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex) when (ex.Number == 1452)
                {
                    MessageBox.Show("El ID del profesor no existe en la tabla de profesores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaEntrega_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkListaEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}




