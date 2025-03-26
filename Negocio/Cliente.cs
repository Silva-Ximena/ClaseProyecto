using System.Data;
using Datos;

namespace Negocio
{
    public class Cliente
    {
        //Crearmos ub objeto de la clase D_Cliente
        private D_Cliente dCliente = new D_Cliente();

        public DataTable MostrarCliente()
        {
            //Creamos un objeto del tipo DataTable que es lo que tenemos que devolver para mostrar en el DataGrid de la capa FrontEnd
            DataTable tabla = new DataTable();
            tabla = dCliente.Mostrar();
            return tabla;
        }
        public void InsertarCliente(string nombre, string apellido, string dni, string email, string direccion)
        {
            dCliente.Insertar(nombre, apellido, dni, email, direccion);
        }

        public void ModificarCliente(string id, string nombre, string apellido, string dni, string email, string direccion)
        {
            int IdConvert = Convert.ToInt32(id);
            dCliente.Modificar(IdConvert, nombre, apellido, dni, email, direccion);
        }

        public void EliminarCliente(string id)
        {
            int idConvert = Convert.ToInt32(id);
            dCliente.Eliminar(idConvert);
        }
    }
}