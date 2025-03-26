using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class D_Cliente
    {
        private DB_Conexion conexion = new DB_Conexion();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                using (MySqlCommand query = new MySqlCommand("SELECT * FROM Clientes", connection))
                {
                    using (MySqlDataReader reader = query.ExecuteReader())
                    {
                        tabla.Load(reader);
                    }
                }
            }
            return tabla;
        }
        public void Insertar(string nombre,string apellido, string dni, string email, string direccion)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                using (MySqlCommand query = new MySqlCommand("INSERT INTO Clientes (Nombre,Apellido,DNI,Email,Direccion) VALUES (@nombre,@apellido,@dni,@email,@direccion)",connection))
                {
                    query.Parameters.AddWithValue("nombre", nombre);
                    query.Parameters.AddWithValue("apellido", apellido);
                    query.Parameters.AddWithValue("dni", dni);
                    query.Parameters.AddWithValue("email", email);
                    query.Parameters.AddWithValue("direccion", direccion);
                    query.ExecuteNonQuery();
                }
            }
        }

        public void Modificar(int id, string nombre, string apellido, string dni, string email, string direccion)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                using (MySqlCommand query = new MySqlCommand("UPDATE Clientes SET Nombre = @nombre, Apellido = @apellido, DNI = @dni, Email = @email, Direccion = @direccion WHERE Id = @id", connection))
                {
                    query.Parameters.AddWithValue("@id", id);
                    query.Parameters.AddWithValue("nombre", nombre);
                    query.Parameters.AddWithValue("apellido", apellido);
                    query.Parameters.AddWithValue("dni", dni);
                    query.Parameters.AddWithValue("email", email);
                    query.Parameters.AddWithValue("direccion", direccion);
                    query.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                using(MySqlCommand query = new MySqlCommand("DELETE FROM Clientes WHERE id = @id", connection))
                {
                    query.Parameters.AddWithValue("@id", id);
                    query.ExecuteNonQuery();
                }
            }
        }
    }
}