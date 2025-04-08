using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestion_tareas.EstrategiasOrdenamiento
{
    public class OrdenarPorFecha : IOrdenarTareas
    {
        public void Ordenar(DataGridView dgvTareasAsignadas)
        {
            try
            {
                if (!dgvTareasAsignadas.Columns.Contains("fecha_entrega"))
                    throw new InvalidOperationException("La columna 'fecha_entrega' no existe en el DataGridView.");
                // Verificar si la columna "fecha_entrega" está configurada para ser ordenada
                if (dgvTareasAsignadas.Columns["fecha_entrega"].SortMode == DataGridViewColumnSortMode.NotSortable)
                    throw new InvalidOperationException("La columna 'fecha_entrega' no está configurada para ser ordenada.");
                dgvTareasAsignadas.Sort(dgvTareasAsignadas.Columns["fecha_entrega"], System.ComponentModel.ListSortDirection.Ascending);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ordenar por fecha: {ex.Message}", "Error de Ordenamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
