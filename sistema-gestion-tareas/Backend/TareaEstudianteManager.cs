using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;

namespace sistema_gestion_tareas
{
    public class TareaEstudianteManager
    {
        private string connectionString = "Server=localhost;Database=usuarios;Uid=root;Pwd=;Port=3306;SslMode=none;";

        public void AsignarTareaAEstudiante(int tareaID, string grupoTarea, string estado, DateTime fecha, string materia)
        {
            Debug.WriteLine($"AsignarTareaAEstudiante - tareaID: {tareaID}, grupoTarea: {grupoTarea}, estado: {estado}, fecha: {fecha}, materia: {materia}");

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    // Obtener los estudiantes del grupo y almacenar sus IDs en una lista
                    List<int> estudiantesIDs = new List<int>();

                    string consultaEstudiantes = "SELECT id FROM estudiantes WHERE grupo = @grupoTarea";
                    using (MySqlCommand cmdEstudiantes = new MySqlCommand(consultaEstudiantes, conexion))
                    {
                        cmdEstudiantes.Parameters.AddWithValue("@grupoTarea", grupoTarea);

                        using (MySqlDataReader readerEstudiantes = cmdEstudiantes.ExecuteReader())
                        {
                            while (readerEstudiantes.Read())
                            {
                                estudiantesIDs.Add(readerEstudiantes.GetInt32("id"));
                            }
                        } // DataReader cerrado
                    }

                    // recorrer la lista de estudiantes e insertar la tarea para cada uno si no existe
                    foreach (int estudianteID in estudiantesIDs)
                    {
                        // Verificar si la combinación de tarea_id y estudiante_id ya existe
                        string consultaExistente = "SELECT COUNT(*) FROM tarea_estudiante WHERE tarea_id = @tareaID AND estudiante_id = @estudianteID";
                        using (MySqlCommand cmdExistente = new MySqlCommand(consultaExistente, conexion))
                        {
                            cmdExistente.Parameters.AddWithValue("@tareaID", tareaID);
                            cmdExistente.Parameters.AddWithValue("@estudianteID", estudianteID);
                            int count = Convert.ToInt32(cmdExistente.ExecuteScalar());

                            if (count == 0)
                            {
                                // Insertar la tarea si no existe
                                string consulta = "INSERT INTO tarea_estudiante (tarea_id, estudiante_id, estado, fecha, materia) VALUES (@tareaID, @estudianteID, @estado, @fecha, @materia)";
                                using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                                {
                                    cmd.Parameters.AddWithValue("@tareaID", tareaID);
                                    cmd.Parameters.AddWithValue("@estudianteID", estudianteID);
                                    cmd.Parameters.AddWithValue("@estado", estado);
                                    cmd.Parameters.AddWithValue("@fecha", fecha);
                                    cmd.Parameters.AddWithValue("@materia", materia);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Tarea asignada correctamente a los estudiantes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al asignar la tarea a los estudiantes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ActualizarTareaEstudiante(int profesorID)
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    // Obtener las tareas del profesor y almacenarlas en una lista
                    List<(int tareaID, DateTime fecha, string materia, string grupoTarea)> tareas = new List<(int, DateTime, string, string)>();

                    string consultaTareas = "SELECT id, fecha_entrega, materia, grupo_asignado FROM tareas WHERE profesor_id = @profesorID";
                    using (MySqlCommand cmdTareas = new MySqlCommand(consultaTareas, conexion))
                    {
                        cmdTareas.Parameters.AddWithValue("@profesorID", profesorID);

                        using (MySqlDataReader readerTareas = cmdTareas.ExecuteReader())
                        {
                            while (readerTareas.Read())
                            {
                                tareas.Add((
                                    readerTareas.GetInt32("id"),
                                    readerTareas.GetDateTime("fecha_entrega"),
                                    readerTareas.GetString("materia"),
                                    readerTareas.GetString("grupo_asignado")
                                ));
                            }
                        } // El reader se cierra automáticamente al salir del using
                    }

                    // recorrer las tareas y asignar los estudiantes
                    foreach (var (tareaID, fecha, materia, grupoTarea) in tareas)
                    {
                        List<int> estudiantesIDs = new List<int>();

                        // Obtener los estudiantes del grupo y almacenarlos en una lista
                        string consultaEstudiantes = "SELECT id FROM estudiantes WHERE grupo = @grupoTarea";
                        using (MySqlCommand cmdEstudiantes = new MySqlCommand(consultaEstudiantes, conexion))
                        {
                            cmdEstudiantes.Parameters.AddWithValue("@grupoTarea", grupoTarea);

                            using (MySqlDataReader readerEstudiantes = cmdEstudiantes.ExecuteReader())
                            {
                                while (readerEstudiantes.Read())
                                {
                                    estudiantesIDs.Add(readerEstudiantes.GetInt32("id"));
                                }
                            } // El reader se cierra automáticamente
                        }

                        // Insertar los datos en la tabla tarea_estudiante si no existen
                        foreach (int estudianteID in estudiantesIDs)
                        {
                            // Verificar si la combinación de tarea_id y estudiante_id ya existe
                            string consultaExistente = "SELECT COUNT(*) FROM tarea_estudiante WHERE tarea_id = @tareaID AND estudiante_id = @estudianteID";
                            using (MySqlCommand cmdExistente = new MySqlCommand(consultaExistente, conexion))
                            {
                                cmdExistente.Parameters.AddWithValue("@tareaID", tareaID);
                                cmdExistente.Parameters.AddWithValue("@estudianteID", estudianteID);
                                int count = Convert.ToInt32(cmdExistente.ExecuteScalar());

                                if (count == 0)
                                {
                                    // Insertar la tarea si no existe
                                    string consulta = "INSERT INTO tarea_estudiante (tarea_id, estudiante_id, estado, fecha, materia) VALUES (@tareaID, @estudianteID, 'Pendiente', @fecha, @materia)";
                                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                                    {
                                        cmd.Parameters.AddWithValue("@tareaID", tareaID);
                                        cmd.Parameters.AddWithValue("@estudianteID", estudianteID);
                                        cmd.Parameters.AddWithValue("@fecha", fecha);
                                        cmd.Parameters.AddWithValue("@materia", materia);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }

                    MessageBox.Show("Tareas actualizadas correctamente para los estudiantes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar las tareas de los estudiantes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}


