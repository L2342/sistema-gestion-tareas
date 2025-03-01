<h1>Proyecto: Sistema de Gestión de Tareas</h1>

**Pasos para instalar:**
1. Clona o descarga el proyecto.
2. Importa la base de datos:
   - Abre phpMyAdmin.
   - Crea una base de datos llamada 'usuarios'.
   - Importa el archivo 'usuarios.sql' desde la carpeta /sql.
3. Configura el archivo de conexión:
   - Abre 'src/Services/SistemaNotificaciones.cs'.
   - Asegúrate de configurar el string de conexión con tus credenciales:
     Server=localhost;Database=usuarios;Uid=root;Pwd=;Port=3306;SslMode=none;
4. Ejecuta el proyecto desde tu IDE favorito (Visual Studio recomendado).
