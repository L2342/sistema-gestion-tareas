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
                    conexion.Conectar(); // Verificaci�n de conexi�n
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error de conexi�n a la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Terminar la aplicaci�n si no hay conexi�n
                }

                ApplicationConfiguration.Initialize();
                Application.Run(new frmRegister());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar la aplicaci�n: {ex.Message}", "Error cr�tico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
