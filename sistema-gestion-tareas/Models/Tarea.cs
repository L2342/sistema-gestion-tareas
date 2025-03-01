using sistema_gestion_tareas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_gestion_tareas.Models
{
    public class Tarea : ISujeto
    {
        public int TareaId { get; set; } // Identificador de la tarea
        public string? Titulo { get; set; } // Nombre de la tarea
        public DateTime FechaEntrega { get; set; } // Fecha de entrega de la tarea
        private List<IObservador> observadores = new List<IObservador>();
        public IReadOnlyList<IObservador> Observadores => observadores;

        public void AgregarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void EliminarObservador(IObservador observador)
        {
            observadores.Remove(observador);
        }

        public void NotificarObservadores()
        {
            foreach (var observador in observadores)
            {
                observador.Notificar($"La tarea '{Titulo}' está próxima a vencer (Fecha de entrega: {FechaEntrega:dd/MM/yyyy}).");
            }
        }

        public void VerificarProximidad(DateTime fechaActual)
        {
            if ((FechaEntrega - fechaActual).TotalDays <= 2)
            {
                NotificarObservadores();
            }
        }
        public List<IObservador> ObtenerObservadores()
        {
            return observadores;
        }
    }
}
