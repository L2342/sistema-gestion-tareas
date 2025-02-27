using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema_gestion_tareas
{
    public partial class frmAddEdit : Form
    {
        private int? tareaID; // Identificador de la tarea (null para crear, valor para editar)
        private ConexionDB conexionDB;

        public frmAddEdit(int? tareaID = null)
        {
            InitializeComponent();
            this.tareaID = tareaID;
            conexionDB = new ConexionDB();
            if (tareaID.HasValue)
            {
                CargarDatosTarea(tareaID.Value); // Cargar datos si estamos en modo edición
            }
        }

        private void CargarDatosTarea(int tareaID)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = conexionDB.Conectar();
                string consulta = "SELECT titulo, descripcion, fecha_entrega, grupo_asignado, materia FROM tareas WHERE id = @tareaID";
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@tareaID", tareaID);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtTitulo.Text = reader["titulo"].ToString();
                    txtDescription.Text = reader["descripcion"].ToString();
                    dtpFechaEntrega.Value = Convert.ToDateTime(reader["fecha_entrega"]);
                    // Asignar otros campos según sea necesario
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string? asignatura = cbxAsignaturas.SelectedItem?.ToString();
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

            // Obtener lista de estudiantes seleccionados
            List<string> estudiantesAsignados = new List<string>();
            foreach (var item in chkListaEstudiantes.CheckedItems)
            {
                estudiantesAsignados.Add(item.ToString());
            }
            if (estudiantesAsignados.Count == 0)
            {
                MessageBox.Show("Debes asignar al menos un grupo de estudiantes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(asignatura))
            {
                MessageBox.Show("Debes seleccionar una asignatura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlConnection conexion = null;
            try
            {
                conexion = conexionDB.Conectar();
                string consulta;
                if (tareaID.HasValue)
                {
                    // Modificar tarea existente
                    consulta = "UPDATE tareas SET titulo = @titulo, descripcion = @descripcion, fecha_entrega = @fechaEntrega, grupo_asignado = @grupoAsignado, materia = @materia WHERE id = @tareaID";
                }
                else
                {
                    // Crear nueva tarea
                    consulta = "INSERT INTO tareas (titulo, descripcion, fecha_entrega, grupo_asignado, materia) VALUES (@titulo, @descripcion, @fechaEntrega, @grupoAsignado, @materia)";
                }

                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@titulo", txtTitulo.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtDescription.Text);
                cmd.Parameters.AddWithValue("@fechaEntrega", dtpFechaEntrega.Value);
                cmd.Parameters.AddWithValue("@grupoAsignado", string.Join(",", estudiantesAsignados));
                cmd.Parameters.AddWithValue("@materia", asignatura);
                if (tareaID.HasValue)
                {
                    cmd.Parameters.AddWithValue("@tareaID", tareaID.Value);
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show(tareaID.HasValue ? "Tarea actualizada correctamente." : "Tarea creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
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

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaEntrega_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
