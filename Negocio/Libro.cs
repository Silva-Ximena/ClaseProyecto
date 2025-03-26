using System.Data;
using Datos;

namespace Negocio
{
    public class Libro
    {
        //Crearmos un objeto de la clase D_Libro
        private D_Libro dLibro = new D_Libro();

        public DataTable MostrarLibro()
        {
            //Creamos un objeto del tipo DataTable que es lo que tenemos que devolver para mostrar en el DataGrid de la capa FrontEnd
            DataTable tabla = new DataTable();
            tabla = dLibro.Mostrar();
            return tabla;
        }
        public void InsertarLibro(string titulo, string autor, string genero, string precio, string stock)
        {
            dLibro.Insertar(titulo,autor,genero,precio,stock);
        }
        public void ModificarLibro(string id_libro, string titulo, string autor, string genero, string precio, string stock)
        {
            int IdConvert = Convert.ToInt32(id_libro);
            float precioConvert = Convert.ToSingle(precio);
            int stockConvert = Convert.ToInt32(stock);
            dLibro.Modificar(IdConvert, titulo, autor, genero, precioConvert, stockConvert);
        }
        public void EliminarLibro(string id_libro)
        {
            int idConvert = Convert.ToInt32(id_libro);
            dLibro.Eliminar(idConvert);
        }
    }
}
