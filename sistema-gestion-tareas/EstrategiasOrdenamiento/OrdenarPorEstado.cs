using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestion_tareas.EstrategiasOrdenamiento
{
    public class OrdenarPorEstado : IOrdenarTareas
    {

        public void Ordenar(DataGridView dgvTareasAsignadas)
        {
            try
            {
                if (!dgvTareasAsignadas.Columns.Contains("Estado"))
                    throw new InvalidOperationException("La columna 'Estado' no existe en el DataGridView.");
                // Verificar si la columna "Estado" está configurada para ser ordenada
                if (dgvTareasAsignadas.Columns["Estado"].SortMode == DataGridViewColumnSortMode.NotSortable)
                    throw new InvalidOperationException("La columna 'Estado' no está configurada para ser ordenada.");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al ordenar por estado: {ex.Message}", "Error de Ordenamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvTareasAsignadas.Sort(dgvTareasAsignadas.Columns["Estado"], System.ComponentModel.ListSortDirection.Ascending); 
        }
    }
}
