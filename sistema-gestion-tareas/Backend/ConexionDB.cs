using System;
using System.Diagnostics;
using MySql.Data.MySqlClient;

public class ConexionDB
{
    private string cadenaConexion = "Server=localhost;Database=usuarios;Uid=root;Pwd=;Port=3306;SslMode=none;";
    public MySqlConnection Conectar()
    {
        MySqlConnection conexion = new MySqlConnection(cadenaConexion);
        try
        {
            conexion.Open();
            Debug.WriteLine("Conexión exitosa a la base de datos.");
        }
        catch (MySqlException ex)
        {
            switch (ex.Number)
            {
                case 1042: // Unable to connect to any of the specified MySQL hosts
                    Debug.WriteLine("No se puede conectar al servidor MySQL: " + ex.Message);
                    break;
                case 1045: // Invalid username/password
                    Debug.WriteLine("Usuario o contraseña incorrectos: " + ex.Message);
                    break;
                case 1049: // Unknown database
                    Debug.WriteLine("Base de datos desconocida: " + ex.Message);
                    break;
                default:
                    Debug.WriteLine("Error de MySQL: " + ex.Message);
                    break;
            }
        }
        catch (TimeoutException ex)
        {
            Debug.WriteLine("Tiempo de espera agotado: " + ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Debug.WriteLine("Operación no válida: " + ex.Message);
        }
        catch (System.Security.Authentication.AuthenticationException ex)
        {
            Debug.WriteLine("Error de autenticación: " + ex.Message);
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Error general al conectar: " + ex.Message);
        }
        return conexion;
    }
}
