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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.Run(new frmLogin());

            ConexionDB conexion = new ConexionDB();
            conexion.Conectar(); // Llamada a la conexión para verificar que funciona



            ApplicationConfiguration.Initialize();
            Application.Run(new frmRegister());
        }
    }
}
