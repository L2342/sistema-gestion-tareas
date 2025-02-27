using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestion_tareas.EstrategiasOrdenamiento
{
    public class OrdenamientoContexto
    {
        private IOrdenarTareas _estrategia;

        public void SetEstrategia(IOrdenarTareas estrategia)
        {
            _estrategia = estrategia;
        }

        public void EjecutarEstrategia(DataGridView dgvTareasAsignadas)
        {
            _estrategia.Ordenar(dgvTareasAsignadas);
        }
    }
}
