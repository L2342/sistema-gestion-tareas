using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

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

            // Verificar si el usuario ya existe
            string consultaVerificar = "SELECT COUNT(*) FROM usuarios WHERE nombre_usuario = @nombreUsuario OR email = @email";
            MySqlCommand cmdVerificar = new MySqlCommand(consultaVerificar, conexion);
            cmdVerificar.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            cmdVerificar.Parameters.AddWithValue("@email", email);

            int usuariosExistentes = Convert.ToInt32(cmdVerificar.ExecuteScalar());
            if (usuariosExistentes > 0)
            {
                Console.WriteLine("El nombre de usuario o email ya existen en la base de datos.");
                return false;
            }

            // Hash de la contraseña para mayor seguridad
            string claveHash = HashClave(clave);

            // Consulta SQL para insertar un nuevo usuario
            string consulta = "INSERT INTO usuarios (nombre_usuario, email, clave, rol) VALUES (@nombreUsuario, @email, @clave, @rol)";

            MySqlCommand cmd = new MySqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@clave", claveHash);
            cmd.Parameters.AddWithValue("@rol", rol);

            int filasAfectadas = cmd.ExecuteNonQuery();
            return filasAfectadas > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al registrar usuario: {ex.Message}");
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
    public bool ValidarLogin(string nombreUsuario, string clave)
    {
        MySqlConnection conexion = null;
        try
        {
            // Obtener la conexión
            conexion = conexionDB.Conectar();

            // Hash de la contraseña para comparar
            string claveHash = HashClave(clave);

            // Consulta SQL para verificar las credenciales
            string consulta = "SELECT COUNT(*) FROM usuarios WHERE nombre_usuario = @nombreUsuario AND clave = @clave";

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

    // Método para obtener información de un usuario
    public DataTable ObtenerUsuario(string nombreUsuario)
    {
        MySqlConnection conexion = null;
        try
        {
            // Obtener la conexión
            conexion = conexionDB.Conectar();

            // Consulta SQL para obtener los datos del usuario
            string consulta = "SELECT id, nombre_usuario, email, rol FROM usuarios WHERE nombre_usuario = @nombreUsuario";

            MySqlCommand cmd = new MySqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            DataTable tablaUsuario = new DataTable();
            adaptador.Fill(tablaUsuario);

            return tablaUsuario;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al obtener usuario: {ex.Message}");
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
}