using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Security;

public class UsuariosBD
{
    private ConexionDB conexionDB;

    public UsuariosBD()
    {
        conexionDB = new ConexionDB();
    }

    // Método para registrar un nuevo usuario
    public bool RegistrarUsuario(string nombreUsuario, string clave, string claveconfir, string email, string rol)
    {
        MySqlConnection conexion = null;
        try
        {
            // Obtener la conexión
            conexion = conexionDB.Conectar();

            // Verificar si el usuario ya existe en la tabla correspondiente
            string consultaVerificar = rol == "Estudiante" ?
                "SELECT COUNT(*) FROM estudiantes WHERE nombre = @nombreUsuario OR correo = @correo" :
                "SELECT COUNT(*) FROM profesores WHERE nombre = @nombreUsuario OR correo = @correo";

            MySqlCommand cmdVerificar = new MySqlCommand(consultaVerificar, conexion);
            cmdVerificar.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            cmdVerificar.Parameters.AddWithValue("@correo", email);

            int usuariosExistentes = Convert.ToInt32(cmdVerificar.ExecuteScalar());
            if (usuariosExistentes > 0)
            {
                Console.WriteLine("El nombre de usuario o email ya existen en la base de datos.");
                return false;
            }

            // Hash de la contraseña para mayor seguridad
            string claveHash = HashClave(clave);

            // Consulta SQL para insertar un nuevo usuario en la tabla correspondiente
            string consulta = rol == "Estudiante" ?
                "INSERT INTO estudiantes (nombre, correo, clave, grupo) VALUES (@nombreUsuario, @correo, @clave, @grupo)" :
                "INSERT INTO profesores (nombre, correo, clave) VALUES (@nombreUsuario, @correo, @clave)";

            MySqlCommand cmd = new MySqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@correo", email);
            cmd.Parameters.AddWithValue("@clave", claveHash);
            if (rol == "Estudiante")
            {
                cmd.Parameters.AddWithValue("@grupo", ""); // Asigna el grupo correspondiente
            }

            int filasAfectadas = cmd.ExecuteNonQuery();
            return filasAfectadas > 0;
        }
        catch (MySqlException ex) when (ex.Number == 1042)
        {
            Console.WriteLine($"No se puede conectar al servidor de base de datos: {ex.Message}");
            return false;
        }
        catch (MySqlException ex) when (ex.Number == 1062)
        {
            Console.WriteLine($"El usuario ya existe en la base de datos: {ex.Message}");
            return false;
        }
        catch (MySqlException ex)
        {
            Console.WriteLine($"Error de MySQL: {ex.Message}");
            return false;
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine($"Error de referencia nula (posiblemente fallo en la conexión): {ex.Message}");
            return false;
        }
        catch (InvalidCastException ex)
        {
            Console.WriteLine($"Error de conversión de tipo de datos: {ex.Message}");
            return false;
        }
        catch (SecurityException ex)
        {
            Console.WriteLine($"Error de seguridad al calcular el hash: {ex.Message}");
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
            return false;
        }
        finally
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }

    // Método para validar el inicio de sesión
    public bool ValidarLogin(string nombreUsuario, string clave, string rol)
    {
        MySqlConnection conexion = null;
        try
        {
            // Obtener la conexión
            conexion = conexionDB.Conectar();

            // Hash de la contraseña para comparar
            string claveHash = HashClave(clave);

            // Consulta SQL para verificar las credenciales en la tabla correspondiente
            string consulta = rol == "Estudiante" ?
                "SELECT COUNT(*) FROM estudiantes WHERE nombre = @nombreUsuario AND clave = @clave" :
                "SELECT COUNT(*) FROM profesores WHERE nombre = @nombreUsuario AND clave = @clave";

            MySqlCommand cmd = new MySqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@clave", claveHash);

            int usuariosValidos = Convert.ToInt32(cmd.ExecuteScalar());
            return usuariosValidos > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al validar login: {ex.Message}");
            return false;
        }
        finally
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }

    // Método para hacer hash de la contraseña
    private string HashClave(string clave)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(clave);
            byte[] hashBytes = sha256.ComputeHash(bytes);

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                builder.Append(hashBytes[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
    public DataTable ObtenerUsuario(string nombreUsuario)
    {
        MySqlConnection conexion = null;
        try
        {
            // Obtener la conexión
            conexion = conexionDB.Conectar();

            // Consulta SQL para obtener los datos del usuario
            string consulta = "SELECT id, nombre, correo, 'Estudiante' AS rol FROM estudiantes WHERE nombre = @nombreUsuario " +
                              "UNION " +
                              "SELECT id, nombre, correo, 'Profesor' AS rol FROM profesores WHERE nombre = @nombreUsuario";

            MySqlCommand cmd = new MySqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            DataTable tablaUsuario = new DataTable();
            adaptador.Fill(tablaUsuario);

            return tablaUsuario;
        }
        catch (MySqlException ex) when(ex.Number == 1042)
        {
            Console.WriteLine($"No se puede conectar al servidor de base de datos: {ex.Message}");
            return null;
        } 
        catch (MySqlException ex) when(ex.Number == 1062)
        {
            Console.WriteLine($"El usuario ya existe en la base de datos: {ex.Message}");
            return null;
        } 
        catch (MySqlException ex) 
        {
            Console.WriteLine($"Error de MySQL: {ex.Message}");
            return null;
        } 
        catch (NullReferenceException ex) 
        {
            Console.WriteLine($"Error de referencia nula (posiblemente fallo en la conexión): {ex.Message}");
            return null;
        } 
        catch (InvalidCastException ex) 
        {
            Console.WriteLine($"Error de conversión de tipo de datos: {ex.Message}");
            return null;
        } 
        catch (SecurityException ex) 
        {
            Console.WriteLine($"Error de seguridad al calcular el hash: {ex.Message}");
            return null;
        } 
        catch (Exception ex) 
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
            return null;
        }
        finally
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
