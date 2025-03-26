using System;
using Negocio;
using System.Data;


namespace FrontEnd
{
    public partial class F_Cliente : Form
    {
        //Instanciamos la clase cliente
        Cliente cliente = new Cliente();
        public F_Cliente()
        {
            InitializeComponent();
            tbox_FC_Id.Enabled = false; // Deshabilitar el campo ID para evitar modificaciones
        }

        //Mostrar clientes
        private void MostrarClientes()
        {
            //Le asigno al DataGrid del FrontEnd las personas a mostrar
            DG_F_Cliente.DataSource = cliente.MostrarCliente();
        }

        private void F_Cliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
            MostrarFecha();
            MostrarHora();
        }

        private void BTN_FC_Cargar_Click(object sender, EventArgs e)
        {
            cliente.InsertarCliente(tbox_FC_Nombre.Text, tbox_FC_Apellido.Text, tbox_FC_DNI.Text, tbox_FC_Email.Text, tbox_FC_Direccion.Text);
            MessageBox.Show("Cliente cargado!");
        }

        private void BTN_FC_Modificar_Click(object sender, EventArgs e)
        {
            cliente.ModificarCliente(tbox_FC_Id.Text,tbox_FC_Nombre.Text, tbox_FC_Apellido.Text, tbox_FC_DNI.Text, tbox_FC_Email.Text, tbox_FC_Direccion.Text);
            MessageBox.Show("Cliente modificado!");
        }

        private void BTN_FC_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show($"¿Estas seguro que deseas eliminar a este cliente id:{tbox_FC_Id.Text}.",
                                            "Confirmacion",
                                            MessageBoxButtons.OKCancel,
                                            MessageBoxIcon.Warning);
            if (resultado ==DialogResult.OK)
            {
                cliente.EliminarCliente(tbox_FC_Id.Text);
                MessageBox.Show("Cliente eliminado!");
            }
            
        }

        // Creamos un método que nos permita tomar los datos de una celda.
        // El sender representa el control que activó el evento(DG_F_Cliente).
        // "e" contiene la información sobre la celda que se hizo clic, como su fila(e.RowIndex).
        private void DG_F_Cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validamos que la fila que seleccionemos sea mayor o igual a 0
            if (e.RowIndex >= 0)
            {
                // Accedemos a la fila del DataGridView correspondiente al índice e.RowIndex.
                DataGridViewRow row = DG_F_Cliente.Rows[e.RowIndex];
                // Le asignamos a los textBox el valor de de la celda y a este valor lo convertimos en string.
                tbox_FC_Id.Text = row.Cells["id"].Value.ToString();
                tbox_FC_Nombre.Text = row.Cells["nombre"].Value.ToString();
                tbox_FC_Apellido.Text = row.Cells["apellido"].Value.ToString();
                tbox_FC_DNI.Text = row.Cells["dni"].Value.ToString();
                tbox_FC_Email.Text = row.Cells["email"].Value.ToString();
                tbox_FC_Direccion.Text = row.Cells["direccion"].Value.ToString();
            }
        }

        private void btn_FC_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_FC_Limpiar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres limpiar todos los campos?",
                                             "Confirmación",
                                             MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Warning);

            if (resultado == DialogResult.OK)
            {
                tbox_FC_Id.Text = null;
                tbox_FC_Nombre.Text = null;
                tbox_FC_Apellido.Text = null;
                tbox_FC_DNI.Text = null;
                tbox_FC_Email.Text = null;
                tbox_FC_Direccion.Text = null;
            }
        }


        private void MostrarFecha()
        {
            lbl_FC_MostrarFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void MostrarHora()
        {
            lbl_FC_MostrarHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void tbox_FC_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (DG_F_Cliente != null)
            {
                string filtro = tbox_FC_Buscar.Text.Trim();
                (DG_F_Cliente.DataSource as DataTable).DefaultView.RowFilter =
                    $"nombre LIKE '%{filtro}%' OR apellido LIKE '%{filtro}%'OR dni LIKE '%{filtro}%' OR email LIKE '%{filtro}%' OR direccion LIKE '%{filtro}%'";
            }
            else
            {
                MessageBox.Show("No hay tablas donde buscar!");
            }
        }
    }
}