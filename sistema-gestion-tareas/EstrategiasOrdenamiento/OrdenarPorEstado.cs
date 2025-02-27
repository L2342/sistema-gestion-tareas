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
            dgvTareasAsignadas.Sort(dgvTareasAsignadas.Columns["Estado"], System.ComponentModel.ListSortDirection.Ascending); 
        }
    }
}
