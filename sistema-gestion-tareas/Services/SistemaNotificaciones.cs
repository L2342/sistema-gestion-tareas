using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using sistema_gestion_tareas.Models;

namespace sistema_gestion_tareas.Services
{
    public class SistemaNotificaciones
    {
        private string connectionString = "Server=localhost;Database=usuarios;Uid=root;Pwd=;Port=3306;SslMode=none;";
        private List<Tarea> tareas = new List<Tarea>();
        // Método para cargar las tareas desde la base de datos
        public void CargarTareas()
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                string consulta = "SELECT id, titulo, fecha_entrega FROM tareas";

                using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tareas.Add(new Tarea
                        {
                            TareaId = Convert.ToInt32(reader["id"]),
                            Titulo = reader["titulo"].ToString(),
                            FechaEntrega = Convert.ToDateTime(reader["fecha_entrega"])
                        });
                    }
                }
            }

            Console.WriteLine("Tareas cargadas correctamente.");
        }
        // Método para cargar los observadores (estudiantes) asociados a las tareas
        public void CargarObservadores()
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                string consulta = @"
                SELECT te.tarea_id, te.estudiante_id
                FROM tarea_estudiante te";

                using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int tareaId = Convert.ToInt32(reader["tarea_id"]);
                        int estudianteId = Convert.ToInt32(reader["estudiante_id"]);

                        
                        var estudiante = new Estudiante(estudianteId);

                        // Buscar la tarea correspondiente y agregar el observador
                        var tarea = tareas.Find(t => t.TareaId == tareaId);
                        if (tarea != null && !tarea.Observadores.Any(o => o is Estudiante e && e.EstudianteID == estudianteId))
                        {
                            tarea.AgregarObservador(estudiante);
                        }
          
                    }
                }
            }

            Console.WriteLine("Observadores cargados correctamente.");
        }
        // Método para verificar la proximidad de las tareas y notificar a los observadores
        
        public void VerificarTareasPorEstudiante(int estudianteId)
        {
            DateTime fechaActual = DateTime.Now;

            // Iteramos solo las tareas asociadas al estudiante
            foreach (var tarea in tareas)
            {
                // Obtenemos los observadores de la tarea
                var observadores = tarea.ObtenerObservadores();

                // Verificamos si el estudiante actual está asociado a la tarea
                var observadorActual = observadores.FirstOrDefault(o => o is Estudiante estudiante && estudiante.EstudianteID == estudianteId);

                if (observadorActual != null)
                {
                    // Si la tarea está próxima a vencer, notificamos al estudiante actual
                    if ((tarea.FechaEntrega - fechaActual).TotalDays <= 2)
                    {
                        observadorActual.Notificar($"La tarea '{tarea.Titulo}' está próxima a vencer (Fecha de entrega: {tarea.FechaEntrega:dd/MM/yyyy}).");
                    }
                }
            }

            Console.WriteLine($"Verificación de tareas completada para el estudiante con ID: {estudianteId}");
        }

    }
}
