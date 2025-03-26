using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class D_Libro
    {
        private DB_Conexion conexion = new DB_Conexion();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                using (MySqlCommand query = new MySqlCommand("SELECT * FROM Libros", connection))
                {
                    using (MySqlDataReader reader = query.ExecuteReader())
                    {
                        tabla.Load(reader);
                    }
                }
            }
            return tabla;
        }

        public void Insertar(string titulo, string autor, string genero, string precio, string stock)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                using (MySqlCommand query = new MySqlCommand("INSERT INTO Libros (Titulo,Autor,Genero,Precio,Stock) VALUES (@titulo,@autor,@genero,@precio,@stock)", connection))
                {
                    
                    query.Parameters.AddWithValue("@titulo", titulo);
                    query.Parameters.AddWithValue("@autor", autor);
                    query.Parameters.AddWithValue("@genero", genero);
                    query.Parameters.AddWithValue("@precio", precio);
                    query.Parameters.AddWithValue("@stock", stock);
                    query.ExecuteNonQuery();
                }
            }
        }

        public void Modificar(int id, string titulo, string autor, string genero, float precio, int stock)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                using (MySqlCommand query = new MySqlCommand("UPDATE Clientes SET Nombre = @nombre, Apellido = @apellido, DNI = @dni, Email = @email, Direccion = @direccion WHERE Id = @id_libro", connection))
                {
                    query.Parameters.AddWithValue("@id_libro", id);
                    query.Parameters.AddWithValue("@Titulo", titulo);
                    query.Parameters.AddWithValue("@Autor", autor);
                    query.Parameters.AddWithValue("@genero", genero);
                    query.Parameters.AddWithValue("@precio", precio);
                    query.Parameters.AddWithValue("@stock", stock);
                    query.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                using (MySqlCommand query = new MySqlCommand("DELETE FROM Libros WHERE id = @id_libro", connection))
                {
                    query.Parameters.AddWithValue("@id_libro", id);
                    query.ExecuteNonQuery();
                }
            }
        }

    }
}