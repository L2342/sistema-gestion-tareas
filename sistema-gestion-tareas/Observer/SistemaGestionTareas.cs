using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace sistema_gestion_tareas.Observer
{
    public class SistemaGestionTareas : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string connectionString = "Server=localhost;Database=usuarios;Uid=root;Pwd=;Port=3306;SslMode=none;";

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }

        public void VerificarFechasEntrega(int estudianteID)
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string consulta = @"
                        SELECT t.titulo, t.fecha_entrega, e.nombre
                        FROM tarea_estudiante te
                        JOIN tareas t ON te.tarea_id = t.id
                        JOIN estudiantes e ON te.estudiante_id = e.id
                        WHERE t.fecha_entrega <= DATE_ADD(CURDATE(), INTERVAL 2 DAY) 
                        AND te.estado != 'Terminada' AND e.id = @estudianteID";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@estudianteID", estudianteID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string titulo = reader.GetString("titulo");
                                DateTime fechaEntrega = reader.GetDateTime("fecha_entrega");
                                string nombreEstudiante = reader.GetString("nombre");

                                string message = $"Hola {nombreEstudiante}, la fecha de entrega de la tarea '{titulo}' es el {fechaEntrega.ToShortDateString()}.";
                                Notify(message);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al verificar las fechas de entrega: " + ex.Message);
                }
            }
        }
    }
}
