using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace sistema_gestion_tareas
{
    public partial class dashboardProfesores : Form
    {
        public dashboardProfesores()
        {
            InitializeComponent();
            CargarTareas();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.Thistle;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            PnlNav.Top = BtnLogOut.Top;
            PnlNav.Left = BtnLogOut.Left;
            BtnLogOut.BackColor = Color.Thistle;
            Sesion.ProfesorID = 0; // Restablecer el ID del profesor al cerrar sesión
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.White;
        }

        private void BtnLogOut_Leave(object sender, EventArgs e)
        {
            BtnLogOut.BackColor = Color.White;
        }

        public void CargarTareas()
        {
            int profesorID = Sesion.ProfesorID;

            if (profesorID <= 0)
            {
                MessageBox.Show("Error: ID de profesor no válido.");
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;database=usuarios;user=root;password="))
                {
                    conexion.Open();
                    Debug.WriteLine("Conexión exitosa a la base de datos.");
                    string consulta = "SELECT id, titulo, descripcion, fecha_entrega, grupo_asignado, materia FROM tareas WHERE profesor_id = @ProfesorID";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ProfesorID", profesorID);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvTareasAsignadas.DataSource = dt;  // Asignar el DataTable al DataGridView

                            // Ocultar la columna id
                            if (dgvTareasAsignadas.Columns["id"] != null)
                            {
                                dgvTareasAsignadas.Columns["id"].Visible = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las tareas: " + ex.Message);
            }
        }

        private void BtnCrearTarea_Click(object sender, EventArgs e)
        {
            frmAddEdit formulario = new frmAddEdit(Sesion.ProfesorID);
            formulario.ShowDialog();
            CargarTareas(); // actualizar el DataGridView con la nueva tarea después de cerrar el formulario
        }

        private void BtnEditarTarea_Click(object sender, EventArgs e)
        {
            if (dgvTareasAsignadas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una tarea para editar.");
                return;
            }

            int tareaID = Convert.ToInt32(dgvTareasAsignadas.SelectedRows[0].Cells["id"].Value);

            frmAddEdit frm = new frmAddEdit(Sesion.ProfesorID, tareaID);
            frm.ShowDialog(); // Abrir en modo edición
            CargarTareas(); // Refrescar la lista después de editar

            // Actualizar la tabla tarea_estudiante
            TareaEstudianteManager tareaEstudianteManager = new TareaEstudianteManager();
            tareaEstudianteManager.ActualizarTareaEstudiante(Sesion.ProfesorID);
        }

        private void BtnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (dgvTareasAsignadas.SelectedRows.Count > 0)
            {
                int tareaID = Convert.ToInt32(dgvTareasAsignadas.SelectedRows[0].Cells["id"].Value); //pendiente de que se llame id 

                // Confirmar eliminación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta tarea?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conexion = new MySqlConnection("server=localhost;database=usuarios;user=root;password="))
                        {
                            conexion.Open();
                            string consulta = "DELETE FROM tareas WHERE id = @tareaID";

                            using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                            {
                                comando.Parameters.AddWithValue("@tareaID", tareaID);
                                comando.ExecuteNonQuery();
                            }

                            // Eliminar las entradas correspondientes en la tabla tarea_estudiante
                            consulta = "DELETE FROM tarea_estudiante WHERE tarea_id = @tareaID";
                            using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                            {
                                comando.Parameters.AddWithValue("@tareaID", tareaID);
                                comando.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Tarea eliminada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTareas(); // Actualizar el DataGridView después de eliminar la tarea
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la tarea: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una tarea para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AcTarea_Click(object sender, EventArgs e)
        {
            if (dgvTareasAsignadas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una tarea para asignar.");
                return;
            }

            int tareaID = Convert.ToInt32(dgvTareasAsignadas.SelectedRows[0].Cells["id"].Value);
            string grupoTarea = dgvTareasAsignadas.SelectedRows[0].Cells["grupo_asignado"].Value?.ToString() ?? string.Empty;
            string estado = "Pendiente"; // Estado inicial de la tarea
            DateTime fecha = Convert.ToDateTime(dgvTareasAsignadas.SelectedRows[0].Cells["fecha_entrega"].Value);
            string materia = dgvTareasAsignadas.SelectedRows[0].Cells["materia"].Value?.ToString() ?? string.Empty;

            Debug.WriteLine($"AcTarea_Click - tareaID: {tareaID}, grupoTarea: {grupoTarea}, estado: {estado}, fecha: {fecha}, materia: {materia}");

            // Consolidar la lógica en un solo método
            TareaEstudianteManager tareaEstudianteManager = new TareaEstudianteManager();
            tareaEstudianteManager.AsignarTareaAEstudiante(tareaID, grupoTarea, estado, fecha, materia);
        }
    }
}

