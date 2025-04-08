using MySql.Data.MySqlClient;

namespace sistema_gestion_tareas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.SetHighDpiMode(HighDpiMode.SystemAware);

                try
                {
                    ConexionDB conexion = new ConexionDB();
                    conexion.Conectar(); // Verificación de conexión
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error de conexión a la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Terminar la aplicación si no hay conexión
                }

                ApplicationConfiguration.Initialize();
                Application.Run(new frmRegister());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar la aplicación: {ex.Message}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
