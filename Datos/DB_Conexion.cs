using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class DB_Conexion
    {
        private static string connection = "Server=localhost;Port=3306;Database=bd_proyectointegrador;User Id=root;Password=;SslMode=none;";

        public MySqlConnection AbrirConexion()
        {
            MySqlConnection conexion = new MySqlConnection(connection);
            conexion.Open();
            return conexion;
        }

        public MySqlConnection CerrarConexion()
        {
            MySqlConnection conexion = new MySqlConnection(connection);
            conexion.Close();
            return conexion;
        }
    }
}