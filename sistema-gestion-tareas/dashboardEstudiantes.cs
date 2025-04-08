using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using sistema_gestion_tareas.EstrategiasOrdenamiento;
using sistema_gestion_tareas.Services;

namespace sistema_gestion_tareas
{
    public partial class dashBoard_Profesores : Form
    {
        private int estudianteID;
        private SistemaNotificaciones sistemaNotificaciones;

        public dashBoard_Profesores()
        {
            InitializeComponent();
        }

        public dashBoard_Profesores(int estudianteID)
        {
            InitializeComponent();
            this.estudianteID = estudianteID;
            VerificarGrupoEstudiante();
            CargarTareasEstudiante();
            sistemaNotificaciones = new SistemaNotificaciones();
            sistemaNotificaciones.CargarTareas();
            sistemaNotificaciones.CargarObservadores();
        }

        private void VerificarGrupoEstudiante()
        {
            string connectionString = "Server=localhost;Database=usuarios;Uid=root;Pwd=;Port=3306;SslMode=none;";
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string consulta = "SELECT grupo FROM estudiantes WHERE id = @estudianteID";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@estudianteID", estudianteID);

                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null && !string.IsNullOrEmpty(resultado.ToString()))
                    {
                        cmbGrupos.Text = resultado.ToString();
                        cmbGrupos.Enabled = false;
                        btnGuardarGrupo.Enabled = false;
                    }
                    else
                    {
                        CargarGrupos();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar el grupo del estudiante: " + ex.Message);
                }
            }
        }

        private void CargarGrupos()
        {
            // Cargar los grupos disponibles en el ComboBox
            cmbGrupos.Items.AddRange(new string[] { "Grupo A", "Grupo B", "Grupo C", "Grupo N" });
        }

        private void btnGuardarGrupo_Click(object sender, EventArgs e)
        {
            // Validar que el usuario haya seleccionado un grupo
            if (cmbGrupos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un grupo antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string? grupoSeleccionado = cmbGrupos.SelectedItem.ToString();

            string connectionString = "Server=localhost;Database=usuarios;Uid=root;Pwd=;Port=3306;SslMode=none;";
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string consulta = "UPDATE estudiantes SET grupo = @grupo WHERE id = @estudianteID AND (grupo IS NULL OR grupo = '')";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@grupo", grupoSeleccionado);
                    cmd.Parameters.AddWithValue("@estudianteID", estudianteID);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Grupo asignado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbGrupos.Enabled = false;  // Bloquear cambios
                        btnGuardarGrupo.Enabled = false;
                        CargarTareasEstudiante(); // Recargar las tareas del estudiante
                    }
                    else
                    {
                        MessageBox.Show("No se pudo asignar el grupo. Puede que ya tengas un grupo asignado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el grupo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarTareasEstudiante()
        {
            string connectionString = "Server=localhost;Database=usuarios;Uid=root;Pwd=;Port=3306;SslMode=none;";
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string consulta = @"
                        SELECT te.id AS TareaEstudianteID, t.titulo, t.descripcion, t.fecha_entrega, t.materia, te.estado
                        FROM tarea_estudiante te
                        JOIN tareas t ON te.tarea_id = t.id
                        WHERE te.estudiante_id = @estudianteID";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@estudianteID", estudianteID);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvTareasDisponibles.DataSource = dt;  // Asignar el DataTable al DataGridView

                            // Ocultar la columna TareaEstudianteID
                            if (dgvTareasDisponibles.Columns["TareaEstudianteID"] != null)
                            {
                                dgvTareasDisponibles.Columns["TareaEstudianteID"].Visible = false;
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las tareas del estudiante: " + ex.Message);
                }
            }
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvTareasDisponibles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila completa válida antes de cambiar el estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvTareasDisponibles.SelectedRows[0];

                // Validar que la celda requerida no sea nula
                if (filaSeleccionada.Cells["TareaEstudianteID"].Value == null)
                {
                    MessageBox.Show("Por favor, selecciona una fila válida con datos completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int tareaEstudianteID = Convert.ToInt32(filaSeleccionada.Cells["TareaEstudianteID"].Value);
                string? nuevoEstado = cmbEstados.SelectedItem?.ToString();
                string? estadoActual = filaSeleccionada.Cells["estado"].Value?.ToString();
                if (string.IsNullOrEmpty(nuevoEstado))
                {
                    MessageBox.Show("Selecciona un estado válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (estadoActual == nuevoEstado)
                {
                    MessageBox.Show($"La tarea ya tiene el estado '{nuevoEstado}'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Actualizar el estado en la base de datos
                string connectionString = "Server=localhost;Database=usuarios;Uid=root;Pwd=;Port=3306;SslMode=none;";
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();
                    string consulta = @"
                    UPDATE tarea_estudiante
                    SET estado = @nuevoEstado
                    WHERE id = @tareaEstudianteID";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);
                        cmd.Parameters.AddWithValue("@tareaEstudianteID", tareaEstudianteID);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show($"El estado se ha actualizado a: {nuevoEstado}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarTareasEstudiante(); // Recargar las tareas
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el estado. Verifica los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // crear el contexto
            OrdenamientoContexto contexto = new OrdenamientoContexto();
            string? criterio = cmbCriterios.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("Selecciona un criterio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // asignar la estrategia
            switch (criterio)
            {
                case "Fecha de entrega":
                    contexto.SetEstrategia(new OrdenarPorFecha());
                    break;
                case "Estado":
                    contexto.SetEstrategia(new OrdenarPorEstado());
                    break;
                case "Asignatura":
                    contexto.SetEstrategia(new OrdenarPorAsignaturas());
                    break;
                default:
                    MessageBox.Show("Criterio no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            // ejecutar Ordenamiento
            contexto.EjecutarOrdenamiento(dgvTareasDisponibles);
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void form_Load(object sender, EventArgs e)
        {
            timerVerificacion.Interval = 3600000;
            timerVerificacion.Tick += timerVerificacion_Tick;
            timerVerificacion.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarGrupo_Click_1(object sender, EventArgs e)
        {
            btnGuardarGrupo_Click(sender, e);
        }

        private void cmbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificarTareas_Click(object sender, EventArgs e)
        {
            sistemaNotificaciones.VerificarTareasPorEstudiante(estudianteID);
            MessageBox.Show("Verificación de tareas completada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timerVerificacion_Tick(object sender, EventArgs e)
        {
            sistemaNotificaciones.VerificarTareasPorEstudiante(estudianteID);
        }
    }
}



