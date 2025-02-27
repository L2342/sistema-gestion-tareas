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
        public frmAddEdit()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("El título es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // PARA EL BACK
            //AQUI IMPLEMENTAR GUARDAR LA INFORMACION EN LA BASE DE DATOS

            MessageBox.Show("Tarea guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
