using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_gestion_tareas.Interfaces
{
    public interface ISujeto
    {
        void AgregarObservador(IObservador observador);
        void EliminarObservador(IObservador observador);
        void NotificarObservadores();
    }
}
