<h1>Proyecto: Sistema de Gestión de Tareas</h1>
<h3>PARTICIPANTES:</h3>
<ol>
   <li>Samuel David Bolivar Trujillo</li>
   <li>Juan David Calderon Diaz</li>
   <li>Daniela Fierro Madrigal</li>
</ol>
**Pasos para instalar:**
<ol>
    <li>Clona o descarga el proyecto.</li>
    <li> Importa la base de datos:
   - Abre phpMyAdmin.
   - Crea una base de datos llamada 'usuarios'.
   - Importa el archivo 'usuarios.sql' desde la carpeta /sql.</li>
    <li>Configura el archivo de conexión</li>
    <li> Abre 'src/Services/SistemaNotificaciones.cs'.
   - Asegúrate de configurar el string de conexión con tus credenciales:
     Server=localhost;Database=usuarios;Uid=root;Pwd=;Port=3306;SslMode=none;</li>
    <li>4. Ejecuta el proyecto desde tu IDE favorito (Visual Studio recomendado).</li>
</ol>

Si quieres probar el codigo desde cero, inicia sesion como estudiante, matriculate a un grupo, registrate como profesor, añade una tarea a un grupo, actualiza las tareas, vuelve a tu sesion de estudiante y prueba las funcionalidades

<h4>Si quieres probar el código con un usuario ya creado y tareas asignadas ingresa con</h4>
usuario: samuel
contraseña: Test123$$

Si tienes problemas con las dependencias, asegúrate de instalar las librerías necesarias mediante NuGet.
Para cualquier duda, contacta conmigo.
