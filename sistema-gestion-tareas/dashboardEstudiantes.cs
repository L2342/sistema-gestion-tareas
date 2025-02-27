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
    public partial class btnOrdenar : Form
    {

        public btnOrdenar()
        {
            InitializeComponent();
        }

        private void CargarTareasEstudiante() // Verificar si es necesario incluir atributo como IDESTUDIANTE
        {
            // AQUI SE IMPLEMENTA EL BACK PARA ACTUALIZAR EL DATAGRID VIEW CON LAS TAREASESTUDIANTE DE LA BASE DE DATOS

        }
        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvTareasAsignadas.Rows.Count > 0)
            {
                string nuevoEstado = cmbEstados.SelectedItem.ToString();
                int idTarea = Convert.ToInt32(dgvTareasAsignadas.CurrentRow.Cells[0].Value); // pendiente que sea la columna correcta para hacer la verificacion
                                                                                             // ACTUALIZAR EL ESTADO DE LA TAREA EN LA BASE DE DATOS
                MessageBox.Show("El estado de la tarea ha sido actualizado.");
                CargarTareasEstudiante(); // Recargar datos; verificar si es necesario incluir atributo como IDESTUDIANTE

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string criterio = cmbCriterios.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("Selecciona un criterio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
