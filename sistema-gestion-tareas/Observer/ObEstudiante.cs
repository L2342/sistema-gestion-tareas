using System;
using System.Windows.Forms;
using sistema_gestion_tareas.Observer; // Asegura que el namespace correcto está siendo usado

namespace sistema_gestion_tareas.Observer
{
    public class ObEstudiante : IObserver
    {
        public int Id { get; set; } 
        public string Nombre { get; set; } 

        public ObEstudiante(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public void Update(string message)
        {
            if (Application.OpenForms.Count > 0)
            {
                Application.OpenForms[0].Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show(message, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                });
            }
            else
            {
                MessageBox.Show(message, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
