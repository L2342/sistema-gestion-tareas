using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_gestion_tareas.Interfaces
{
    public interface IObservador
    {
        void Notificar(string mensaje); // recibir notificaciones
    }
}
