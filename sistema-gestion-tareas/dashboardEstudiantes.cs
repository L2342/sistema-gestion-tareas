using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema_gestion_tareas.EstrategiasOrdenamiento;

namespace sistema_gestion_tareas
{
    public partial class dashBoard_Profesores : Form
    {

        public dashBoard_Profesores()
        {
            InitializeComponent();
        }

        private void CargarTareasEstudiante() // Verificar si es necesario incluir atributo como IDESTUDIANTE
        {
            // AQUI SE IMPLEMENTA EL BACK PARA ACTUALIZAR EL DATAGRID VIEW CON LAS TAREASESTUDIANTE DE LA BASE DE DATOS

        }
        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvTareasAsignadas.Rows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int tareaEstudianteID = Convert.ToInt32(dgvTareasAsignadas.SelectedRows[0].Cells["TareaEstudianteID"].Value); //pendiente de que sea la columna correcta
            string? nuevoEstado = cmbEstados.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(nuevoEstado))
            {
                MessageBox.Show("Selecciona un estado válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // ACTUALIZAR EL ESTADO DE LA TAREA EN LA BASE DE DATOS
            MessageBox.Show("El estado de la tarea ha sido actualizado.");
            CargarTareasEstudiante(); // Recargar datos; verificar si es necesario incluir atributo como IDESTUDIANTE
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
            contexto.EjecutarOrdenamiento(dgvTareasAsignadas);
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void form_Load(object sender, EventArgs e)
        {

        }
    }
}
