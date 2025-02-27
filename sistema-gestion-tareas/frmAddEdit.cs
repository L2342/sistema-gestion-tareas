using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestion_tareas
{

    public partial class frmAddEdit : Form
    {
        private int? tareaID; // Identificador de la tarea (null para crear, valor para editar)
        public frmAddEdit(int? tareaID = null)
        {
            InitializeComponent();
            this.tareaID = tareaID;
            if (tareaID.HasValue)
            {
                CargarDatosTarea(tareaID.Value); // Cargar datos si estamos en modo edición
            }
        }
        private void CargarDatosTarea(int tareaID)
        {
            // AQUI SE IMPLEMENTA EL BACK PARA CARGAR LOS DATOS DE LA TAREA DE LA BASE DE DATOS
            // PARA RELLENAR LOS CAMPOS DEL FORMULARIO
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string? asignatura = cbxAsignaturas.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("El título es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrWhiteSpace(txtDescription.Text))
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
            try
            {
                // PARA EL BACK
                //AQUI IMPLEMENTAR GUARDAR LA INFORMACION EN LA BASE DE DATOS

                if(tareaID.HasValue)
                {
                    // Modificar tarea existente
                }
                else
                {
                    // Crear nueva tarea
                }
                MessageBox.Show(tareaID.HasValue ? "Tarea actualizada correctamente." : "Tarea creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
