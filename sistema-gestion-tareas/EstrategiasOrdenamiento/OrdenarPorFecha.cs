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
            dgvTareasAsignadas.Sort(dgvTareasAsignadas.Columns["fecha_entrega"],System.ComponentModel.ListSortDirection.Ascending);
        }
    }
}
