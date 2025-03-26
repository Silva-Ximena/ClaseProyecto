using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class F_P : Form
    {
        public F_P()
        {
            InitializeComponent();
        }

        private void BIENVENIDOS_Click(object sender, EventArgs e)
        {

        }

        private void F_P_Load(object sender, EventArgs e)
        {

        }

        private void Btn_FP_Clientes_Click(object sender, EventArgs e)
        {
            F_Cliente cliente = new F_Cliente();
            cliente.Show();
        }

        private void Btn_FP_Libros_Click(object sender, EventArgs e)
        {
            F_Libro libro = new F_Libro();
            libro.Show();
        }
    }
}
