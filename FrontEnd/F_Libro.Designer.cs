namespace FrontEnd
{
    partial class F_Libro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DG_F_Libro = new DataGridView();
            F = new Label();
            tbox_FL_Titulo = new TextBox();
            txt_FL_Titulo = new Label();
            txt_FL_Autor = new Label();
            txt_FL_Género = new Label();
            tbox_FL_Autor = new TextBox();
            tbox_FL_Género = new TextBox();
            tbox_FL_Precio = new TextBox();
            tbox_FL_Stock = new TextBox();
            txt_FL_Precio = new Label();
            txt_FL_Stock = new Label();
            btn_FL_Cargar = new Button();
            btn_FL_Modificar = new Button();
            btn_FL_Eliminar = new Button();
            btn_FL_Limpiar = new Button();
            tbox_FL_Id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DG_F_Libro).BeginInit();
            SuspendLayout();
            // 
            // DG_F_Libro
            // 
            DG_F_Libro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_F_Libro.Location = new Point(12, 288);
            DG_F_Libro.Name = "DG_F_Libro";
            DG_F_Libro.Size = new Size(776, 150);
            DG_F_Libro.TabIndex = 0;
            DG_F_Libro.CellClick += DG_F_Libro_CellClick;
            // 
            // F
            // 
            F.AutoSize = true;
            F.Font = new Font("Script MT Bold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            F.Location = new Point(246, 9);
            F.Name = "F";
            F.Size = new Size(377, 44);
            F.TabIndex = 1;
            F.Text = "Administrador de Libros";
            // 
            // tbox_FL_Titulo
            // 
            tbox_FL_Titulo.Location = new Point(88, 52);
            tbox_FL_Titulo.Name = "tbox_FL_Titulo";
            tbox_FL_Titulo.Size = new Size(100, 23);
            tbox_FL_Titulo.TabIndex = 2;
            tbox_FL_Titulo.TextChanged += textBox1_TextChanged;
            // 
            // txt_FL_Titulo
            // 
            txt_FL_Titulo.AutoSize = true;
            txt_FL_Titulo.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_FL_Titulo.Location = new Point(12, 55);
            txt_FL_Titulo.Name = "txt_FL_Titulo";
            txt_FL_Titulo.Size = new Size(54, 20);
            txt_FL_Titulo.TabIndex = 3;
            txt_FL_Titulo.Text = "Titulo";
            txt_FL_Titulo.Click += BTN_FL_Cargar_Click;
            // 
            // txt_FL_Autor
            // 
            txt_FL_Autor.AutoSize = true;
            txt_FL_Autor.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_FL_Autor.Location = new Point(12, 96);
            txt_FL_Autor.Name = "txt_FL_Autor";
            txt_FL_Autor.Size = new Size(50, 20);
            txt_FL_Autor.TabIndex = 4;
            txt_FL_Autor.Text = "Autor";
            // 
            // txt_FL_Género
            // 
            txt_FL_Género.AutoSize = true;
            txt_FL_Género.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_FL_Género.Location = new Point(12, 141);
            txt_FL_Género.Name = "txt_FL_Género";
            txt_FL_Género.Size = new Size(66, 20);
            txt_FL_Género.TabIndex = 5;
            txt_FL_Género.Text = "Género";
            // 
            // tbox_FL_Autor
            // 
            tbox_FL_Autor.Location = new Point(88, 93);
            tbox_FL_Autor.Name = "tbox_FL_Autor";
            tbox_FL_Autor.Size = new Size(100, 23);
            tbox_FL_Autor.TabIndex = 6;
            // 
            // tbox_FL_Género
            // 
            tbox_FL_Género.Location = new Point(88, 138);
            tbox_FL_Género.Name = "tbox_FL_Género";
            tbox_FL_Género.Size = new Size(100, 23);
            tbox_FL_Género.TabIndex = 7;
            // 
            // tbox_FL_Precio
            // 
            tbox_FL_Precio.Location = new Point(88, 184);
            tbox_FL_Precio.Name = "tbox_FL_Precio";
            tbox_FL_Precio.Size = new Size(100, 23);
            tbox_FL_Precio.TabIndex = 8;
            tbox_FL_Precio.TextChanged += textBox4_TextChanged;
            // 
            // tbox_FL_Stock
            // 
            tbox_FL_Stock.Location = new Point(88, 224);
            tbox_FL_Stock.Name = "tbox_FL_Stock";
            tbox_FL_Stock.Size = new Size(100, 23);
            tbox_FL_Stock.TabIndex = 9;
            // 
            // txt_FL_Precio
            // 
            txt_FL_Precio.AutoSize = true;
            txt_FL_Precio.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_FL_Precio.Location = new Point(14, 187);
            txt_FL_Precio.Name = "txt_FL_Precio";
            txt_FL_Precio.Size = new Size(58, 20);
            txt_FL_Precio.TabIndex = 10;
            txt_FL_Precio.Text = "Precio";
            txt_FL_Precio.Click += label4_Click;
            // 
            // txt_FL_Stock
            // 
            txt_FL_Stock.AutoSize = true;
            txt_FL_Stock.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_FL_Stock.Location = new Point(18, 227);
            txt_FL_Stock.Name = "txt_FL_Stock";
            txt_FL_Stock.Size = new Size(49, 20);
            txt_FL_Stock.TabIndex = 11;
            txt_FL_Stock.Text = "Stock";
            // 
            // btn_FL_Cargar
            // 
            btn_FL_Cargar.Location = new Point(527, 92);
            btn_FL_Cargar.Name = "btn_FL_Cargar";
            btn_FL_Cargar.Size = new Size(75, 23);
            btn_FL_Cargar.TabIndex = 12;
            btn_FL_Cargar.Text = "Cargar";
            btn_FL_Cargar.UseVisualStyleBackColor = true;
            btn_FL_Cargar.Click += BTN_FL_Cargar_Click;
            // 
            // btn_FL_Modificar
            // 
            btn_FL_Modificar.Location = new Point(527, 137);
            btn_FL_Modificar.Name = "btn_FL_Modificar";
            btn_FL_Modificar.Size = new Size(75, 23);
            btn_FL_Modificar.TabIndex = 13;
            btn_FL_Modificar.Text = "Modificar";
            btn_FL_Modificar.UseVisualStyleBackColor = true;
            btn_FL_Modificar.Click += BTN_Fl_Modificar_Click;
            // 
            // btn_FL_Eliminar
            // 
            btn_FL_Eliminar.Location = new Point(527, 183);
            btn_FL_Eliminar.Name = "btn_FL_Eliminar";
            btn_FL_Eliminar.Size = new Size(75, 23);
            btn_FL_Eliminar.TabIndex = 14;
            btn_FL_Eliminar.Text = "Eliminar";
            btn_FL_Eliminar.UseVisualStyleBackColor = true;
            btn_FL_Eliminar.Click += BTN_FL_Eliminar_Click;
            // 
            // btn_FL_Limpiar
            // 
            btn_FL_Limpiar.Location = new Point(527, 223);
            btn_FL_Limpiar.Name = "btn_FL_Limpiar";
            btn_FL_Limpiar.Size = new Size(75, 23);
            btn_FL_Limpiar.TabIndex = 15;
            btn_FL_Limpiar.Text = "Limpiar";
            btn_FL_Limpiar.UseVisualStyleBackColor = true;
            btn_FL_Limpiar.Click += BTN_FL_Limpiar_Click;
            // 
            // tbox_FL_Id
            // 
            tbox_FL_Id.Location = new Point(246, 79);
            tbox_FL_Id.Name = "tbox_FL_Id";
            tbox_FL_Id.Size = new Size(205, 23);
            tbox_FL_Id.TabIndex = 16;
            // 
            // F_Libro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbox_FL_Id);
            Controls.Add(btn_FL_Limpiar);
            Controls.Add(btn_FL_Eliminar);
            Controls.Add(btn_FL_Modificar);
            Controls.Add(btn_FL_Cargar);
            Controls.Add(txt_FL_Stock);
            Controls.Add(txt_FL_Precio);
            Controls.Add(tbox_FL_Stock);
            Controls.Add(tbox_FL_Precio);
            Controls.Add(tbox_FL_Género);
            Controls.Add(tbox_FL_Autor);
            Controls.Add(txt_FL_Género);
            Controls.Add(txt_FL_Autor);
            Controls.Add(txt_FL_Titulo);
            Controls.Add(tbox_FL_Titulo);
            Controls.Add(F);
            Controls.Add(DG_F_Libro);
            Name = "F_Libro";
            Text = "F_Libro";
            Load += F_Libro_Load;
            ((System.ComponentModel.ISupportInitialize)DG_F_Libro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DG_F_Libro;
        private Label F;
        private TextBox tbox_FL_Titulo;
        private Label txt_FL_Titulo;
        private Label txt_FL_Autor;
        private Label txt_FL_Género;
        private TextBox tbox_FL_Autor;
        private TextBox tbox_FL_Género;
        private TextBox tbox_FL_Precio;
        private TextBox tbox_FL_Stock;
        private Label txt_FL_Precio;
        private Label txt_FL_Stock;
        private Button btn_FL_Cargar;
        private Button btn_FL_Modificar;
        private Button btn_FL_Eliminar;
        private Button btn_FL_Limpiar;
        private TextBox tbox_FL_Id;
    }
}