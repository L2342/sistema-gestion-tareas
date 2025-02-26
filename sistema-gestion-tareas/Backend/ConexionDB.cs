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
        catch (Exception ex)
        {
            Debug.WriteLine("Error al conectar a la base de datos: " + ex.Message);
        }
        return conexion;
    }
}
