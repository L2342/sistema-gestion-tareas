using sistema_gestion_tareas.EstrategiasOrdenamiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestion_tareas.EstrategiasOrdenamiento
{
    public class OrdenarPorAsignaturas : IOrdenarTareas
    {
        public void Ordenar(DataGridView dgvTareasAsignadas)
        {
            try
            {
                if (!dgvTareasAsignadas.Columns.Contains("materia"))
                    throw new InvalidOperationException("La columna 'materia' no existe en el DataGridView.");
                // Verificar si la columna "materia" está configurada para ser ordenada
                if (dgvTareasAsignadas.Columns["materia"].SortMode == DataGridViewColumnSortMode.NotSortable)
                    throw new InvalidOperationException("La columna 'materia' no está configurada para ser ordenada.");


                // Ordenar por la columna "materia"
                dgvTareasAsignadas.Sort(dgvTareasAsignadas.Columns["materia"], System.ComponentModel.ListSortDirection.Ascending);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ordenar por asignaturas: {ex.Message}", "Error de Ordenamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvTareasAsignadas.Sort(dgvTareasAsignadas.Columns["materia"], System.ComponentModel.ListSortDirection.Ascending);
            }
        }
    }
}

