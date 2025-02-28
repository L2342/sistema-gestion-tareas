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

        public frmAddEdit(int profesorID, int? tareaID = null)
        {
            InitializeComponent();
            this.profesorID = profesorID;
            this.tareaID = tareaID;
            conexionDB = new ConexionDB();

            // Mostrar el valor de profesorID para depuración
            Debug.WriteLine("Usuario ID recibido: " + profesorID);

            if (tareaID.HasValue)
            {
                CargarDatosTarea();
            }
        }

        private void CargarDatosTarea()
        {
            string connectionString = "Server=localhost;Database=usuarios;Uid=root;Pwd=;Port=3306;SslMode=none;";
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string consulta = "SELECT titulo, descripcion, fecha_entrega, grupo_asignado, materia FROM tareas WHERE id = @tareaID";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@tareaID", tareaID);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtTitulo.Text = reader["titulo"].ToString();
                        txtDescription.Text = reader["descripcion"].ToString();
                        dtpFechaEntrega.Value = Convert.ToDateTime(reader["fecha_entrega"]);
                        comboBox1.SelectedItem = reader["grupo_asignado"].ToString();
                        cbxAsignaturas.SelectedItem = reader["materia"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la tarea: " + ex.Message);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                cbxAsignaturas.SelectedItem == null ||
                comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            string connectionString = "Server=localhost;Database=usuarios;Uid=root;Pwd=;Port=3306;SslMode=none;";
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string consulta;

                    if (tareaID.HasValue)
                    {
                        // Si tareaID tiene valor, actualizar la tarea existente
                        consulta = "UPDATE tareas SET titulo = @titulo, descripcion = @descripcion, " +
                                   "fecha_entrega = @fechaEntrega, grupo_asignado = @grupoAsignado, " +
                                   "materia = @materia WHERE id = @tareaID";
                    }
                    else
                    {
                        // Si no, crear una nueva tarea
                        consulta = "INSERT INTO tareas (titulo, descripcion, fecha_entrega, grupo_asignado, profesor_id, materia) " +
                                   "VALUES (@titulo, @descripcion, @fechaEntrega, @grupoAsignado, @profesorID, @materia)";
                    }

                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@titulo", txtTitulo.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@fechaEntrega", dtpFechaEntrega.Value);
                    cmd.Parameters.AddWithValue("@grupoAsignado", comboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@materia", cbxAsignaturas.SelectedItem.ToString());

                    if (tareaID.HasValue)
                        cmd.Parameters.AddWithValue("@tareaID", tareaID);
                    else
                        cmd.Parameters.AddWithValue("@profesorID", profesorID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tarea guardada correctamente.");
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
                this.Close(); // Cierra la ventana
                dashboardProfesores dashboard = Application.OpenForms["dashboardProfesores"] as dashboardProfesores;
                if (dashboard != null)
                {
                    dashboard.CargarTareas(); // Vuelve a cargar las tareas
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
