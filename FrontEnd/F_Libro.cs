using System;
using Negocio;
using System.Data;

namespace FrontEnd
{
    public partial class F_Libro : Form
    {
        Libro libro = new Libro();
        public F_Libro()
        {
            InitializeComponent();
            tbox_FL_Id.Enabled = false;
        }
        private void MostrarLibros()
        {
            DG_F_Libro.DataSource = libro.MostrarLibro();
        }
        private void F_Libro_Load(object sender, EventArgs e)
        {
            MostrarLibros();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BTN_FL_Cargar_Click(object sender, EventArgs e)
        {
            libro.InsertarLibro(tbox_FL_Titulo.Text, tbox_FL_Autor.Text, tbox_FL_Género.Text, tbox_FL_Precio.Text, tbox_FL_Stock.Text);
            MessageBox.Show("Libro cargado!");
        }
        private void BTN_Fl_Modificar_Click(object sender, EventArgs e)
        {
            libro.ModificarLibro(tbox_FL_Id.Text, tbox_FL_Titulo.Text, tbox_FL_Autor.Text, tbox_FL_Género.Text, tbox_FL_Precio.Text, tbox_FL_Stock.Text);
            MessageBox.Show("Libro modificado!");
        }
        private void BTN_FL_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show($"¿Estas seguro que deseas eliminar a este libro id:{tbox_FL_Id.Text}.",
                                           "Confirmacion",
                                           MessageBoxButtons.OKCancel,
                                           MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                libro.EliminarLibro(tbox_FL_Id.Text);
                MessageBox.Show("Libro eliminado!");
            }
        }
        private void DG_F_Libro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validamos que la fila que seleccionemos sea mayor o igual a 0
            if (e.RowIndex >= 0)
            {
                // Accedemos a la fila del DataGridView correspondiente al índice e.RowIndex.
                DataGridViewRow row = DG_F_Libro.Rows[e.RowIndex];
                // Le asignamos a los textBox el valor de de la celda y a este valor lo convertimos en string.
                tbox_FL_Id.Text = row.Cells["id_libro"].Value.ToString();
                tbox_FL_Titulo.Text = row.Cells["titulo"].Value.ToString();
                tbox_FL_Autor.Text = row.Cells["autor"].Value.ToString();
                tbox_FL_Género.Text = row.Cells["genero"].Value.ToString();
                tbox_FL_Precio.Text = row.Cells["precio"].Value.ToString();
                tbox_FL_Stock.Text = row.Cells["stock"].Value.ToString();
            }
        }
        private void btn_FL_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BTN_FL_Limpiar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres limpiar todos los campos?",
                                             "Confirmación",
                                             MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Warning);

            if (resultado == DialogResult.OK)
            {
                tbox_FL_Id.Text = null;
                tbox_FL_Titulo.Text = null;
                tbox_FL_Autor.Text = null;
                tbox_FL_Género.Text = null;
                tbox_FL_Precio.Text = null;
                tbox_FL_Stock.Text = null;
            }
        }

       
    }
}
