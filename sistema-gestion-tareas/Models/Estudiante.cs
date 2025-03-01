using sistema_gestion_tareas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_gestion_tareas.Models
{
    public class Estudiante : IObservador
    {
        public int EstudianteID { get; set; } // Identificador del estudiante
        public Estudiante(int id)
        {
            EstudianteID = id;
        }

        public void Notificar(string mensaje)
        {
            MessageBox.Show(mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
