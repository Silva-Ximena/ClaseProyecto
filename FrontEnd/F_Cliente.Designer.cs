namespace FrontEnd
{
    partial class F_Cliente
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
            lbl_FC_TituloP = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btn_FC_Cargar = new Button();
            btn_FC_Modificar = new Button();
            btn_FC_Eliminar = new Button();
            txt_FC_Id = new Label();
            tbox_FC_Id = new TextBox();
            btn_FC_Volver = new Button();
            btn_FC_Limpiar = new Button();
            gbox_FC_Datos = new GroupBox();
            tbox_FC_Nombre = new TextBox();
            txt_FC_Direccion = new Label();
            tbox_FC_Direccion = new TextBox();
            tbox_FC_Email = new TextBox();
            tbox_FC_DNI = new TextBox();
            tbox_FC_Apellido = new TextBox();
            txt_FC_Email = new Label();
            txt_FC_DNI = new Label();
            txt_FC_Apellido = new Label();
            txt_FC_Nombre = new Label();
            lbl_FC_Fecha = new Label();
            lbl_FC_Hora = new Label();
            lbl_FC_MostrarFecha = new Label();
            lbl_FC_MostrarHora = new Label();
            gbox_FC_Lista = new GroupBox();
            lbl_FC_Buscar = new Label();
            tbox_FC_Buscar = new TextBox();
            DG_F_Cliente = new DataGridView();
            gbox_FC_Datos.SuspendLayout();
            gbox_FC_Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DG_F_Cliente).BeginInit();
            SuspendLayout();
            // 
            // lbl_FC_TituloP
            // 
            lbl_FC_TituloP.AutoSize = true;
            lbl_FC_TituloP.Font = new Font("Arial Black", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_FC_TituloP.Location = new Point(336, 9);
            lbl_FC_TituloP.Name = "lbl_FC_TituloP";
            lbl_FC_TituloP.Size = new Size(426, 41);
            lbl_FC_TituloP.TabIndex = 1;
            lbl_FC_TituloP.Text = "Administrador de clientes";
            lbl_FC_TituloP.TextAlign = ContentAlignment.TopCenter;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btn_FC_Cargar
            // 
            btn_FC_Cargar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_FC_Cargar.Location = new Point(435, 200);
            btn_FC_Cargar.Name = "btn_FC_Cargar";
            btn_FC_Cargar.Size = new Size(100, 50);
            btn_FC_Cargar.TabIndex = 2;
            btn_FC_Cargar.Text = "Cargar";
            btn_FC_Cargar.UseVisualStyleBackColor = true;
            btn_FC_Cargar.Click += BTN_FC_Cargar_Click;
            // 
            // btn_FC_Modificar
            // 
            btn_FC_Modificar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_FC_Modificar.Location = new Point(541, 200);
            btn_FC_Modificar.Name = "btn_FC_Modificar";
            btn_FC_Modificar.Size = new Size(100, 50);
            btn_FC_Modificar.TabIndex = 13;
            btn_FC_Modificar.Text = "Modificar";
            btn_FC_Modificar.UseVisualStyleBackColor = true;
            btn_FC_Modificar.Click += BTN_FC_Modificar_Click;
            // 
            // btn_FC_Eliminar
            // 
            btn_FC_Eliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_FC_Eliminar.Location = new Point(541, 267);
            btn_FC_Eliminar.Name = "btn_FC_Eliminar";
            btn_FC_Eliminar.Size = new Size(100, 50);
            btn_FC_Eliminar.TabIndex = 14;
            btn_FC_Eliminar.Text = "Eliminar";
            btn_FC_Eliminar.UseVisualStyleBackColor = true;
            btn_FC_Eliminar.Click += BTN_FC_Eliminar_Click;
            // 
            // txt_FC_Id
            // 
            txt_FC_Id.AutoSize = true;
            txt_FC_Id.Location = new Point(424, -33);
            txt_FC_Id.Name = "txt_FC_Id";
            txt_FC_Id.Size = new Size(18, 15);
            txt_FC_Id.TabIndex = 15;
            txt_FC_Id.Text = "ID";
            // 
            // tbox_FC_Id
            // 
            tbox_FC_Id.Location = new Point(491, -33);
            tbox_FC_Id.Name = "tbox_FC_Id";
            tbox_FC_Id.Size = new Size(269, 23);
            tbox_FC_Id.TabIndex = 16;
            // 
            // btn_FC_Volver
            // 
            btn_FC_Volver.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_FC_Volver.Location = new Point(896, 275);
            btn_FC_Volver.Name = "btn_FC_Volver";
            btn_FC_Volver.Size = new Size(88, 50);
            btn_FC_Volver.TabIndex = 17;
            btn_FC_Volver.Text = "Volver";
            btn_FC_Volver.UseVisualStyleBackColor = true;
            btn_FC_Volver.Click += btn_FC_Volver_Click;
            // 
            // btn_FC_Limpiar
            // 
            btn_FC_Limpiar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_FC_Limpiar.Location = new Point(435, 267);
            btn_FC_Limpiar.Name = "btn_FC_Limpiar";
            btn_FC_Limpiar.Size = new Size(100, 50);
            btn_FC_Limpiar.TabIndex = 18;
            btn_FC_Limpiar.Text = "Limpiar";
            btn_FC_Limpiar.UseVisualStyleBackColor = true;
            btn_FC_Limpiar.Click += btn_FC_Limpiar_Click;
            // 
            // gbox_FC_Datos
            // 
            gbox_FC_Datos.Controls.Add(tbox_FC_Nombre);
            gbox_FC_Datos.Controls.Add(txt_FC_Direccion);
            gbox_FC_Datos.Controls.Add(tbox_FC_Direccion);
            gbox_FC_Datos.Controls.Add(tbox_FC_Email);
            gbox_FC_Datos.Controls.Add(tbox_FC_DNI);
            gbox_FC_Datos.Controls.Add(tbox_FC_Apellido);
            gbox_FC_Datos.Controls.Add(txt_FC_Email);
            gbox_FC_Datos.Controls.Add(txt_FC_DNI);
            gbox_FC_Datos.Controls.Add(txt_FC_Apellido);
            gbox_FC_Datos.Controls.Add(txt_FC_Nombre);
            gbox_FC_Datos.Location = new Point(12, 62);
            gbox_FC_Datos.Name = "gbox_FC_Datos";
            gbox_FC_Datos.Size = new Size(417, 258);
            gbox_FC_Datos.TabIndex = 19;
            gbox_FC_Datos.TabStop = false;
            gbox_FC_Datos.Text = "Datos";
            // 
            // tbox_FC_Nombre
            // 
            tbox_FC_Nombre.Location = new Point(80, 39);
            tbox_FC_Nombre.Name = "tbox_FC_Nombre";
            tbox_FC_Nombre.Size = new Size(268, 23);
            tbox_FC_Nombre.TabIndex = 13;
            // 
            // txt_FC_Direccion
            // 
            txt_FC_Direccion.AutoSize = true;
            txt_FC_Direccion.Location = new Point(8, 213);
            txt_FC_Direccion.Name = "txt_FC_Direccion";
            txt_FC_Direccion.Size = new Size(57, 15);
            txt_FC_Direccion.TabIndex = 22;
            txt_FC_Direccion.Text = "Direccion";
            // 
            // tbox_FC_Direccion
            // 
            tbox_FC_Direccion.Location = new Point(80, 210);
            tbox_FC_Direccion.Name = "tbox_FC_Direccion";
            tbox_FC_Direccion.Size = new Size(267, 23);
            tbox_FC_Direccion.TabIndex = 21;
            // 
            // tbox_FC_Email
            // 
            tbox_FC_Email.Location = new Point(79, 170);
            tbox_FC_Email.Name = "tbox_FC_Email";
            tbox_FC_Email.Size = new Size(268, 23);
            tbox_FC_Email.TabIndex = 20;
            // 
            // tbox_FC_DNI
            // 
            tbox_FC_DNI.Location = new Point(80, 126);
            tbox_FC_DNI.Name = "tbox_FC_DNI";
            tbox_FC_DNI.Size = new Size(267, 23);
            tbox_FC_DNI.TabIndex = 19;
            // 
            // tbox_FC_Apellido
            // 
            tbox_FC_Apellido.Location = new Point(80, 83);
            tbox_FC_Apellido.Name = "tbox_FC_Apellido";
            tbox_FC_Apellido.Size = new Size(267, 23);
            tbox_FC_Apellido.TabIndex = 18;
            // 
            // txt_FC_Email
            // 
            txt_FC_Email.AutoSize = true;
            txt_FC_Email.Location = new Point(8, 173);
            txt_FC_Email.Name = "txt_FC_Email";
            txt_FC_Email.Size = new Size(36, 15);
            txt_FC_Email.TabIndex = 17;
            txt_FC_Email.Text = "Email";
            // 
            // txt_FC_DNI
            // 
            txt_FC_DNI.AutoSize = true;
            txt_FC_DNI.Location = new Point(11, 126);
            txt_FC_DNI.Name = "txt_FC_DNI";
            txt_FC_DNI.Size = new Size(27, 15);
            txt_FC_DNI.TabIndex = 16;
            txt_FC_DNI.Text = "DNI";
            // 
            // txt_FC_Apellido
            // 
            txt_FC_Apellido.AutoSize = true;
            txt_FC_Apellido.Location = new Point(11, 87);
            txt_FC_Apellido.Name = "txt_FC_Apellido";
            txt_FC_Apellido.Size = new Size(51, 15);
            txt_FC_Apellido.TabIndex = 15;
            txt_FC_Apellido.Text = "Apellido";
            // 
            // txt_FC_Nombre
            // 
            txt_FC_Nombre.AutoSize = true;
            txt_FC_Nombre.Location = new Point(11, 42);
            txt_FC_Nombre.Name = "txt_FC_Nombre";
            txt_FC_Nombre.Size = new Size(51, 15);
            txt_FC_Nombre.TabIndex = 14;
            txt_FC_Nombre.Text = "Nombre";
            // 
            // lbl_FC_Fecha
            // 
            lbl_FC_Fecha.AutoSize = true;
            lbl_FC_Fecha.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            lbl_FC_Fecha.Location = new Point(841, 82);
            lbl_FC_Fecha.Name = "lbl_FC_Fecha";
            lbl_FC_Fecha.Size = new Size(46, 20);
            lbl_FC_Fecha.TabIndex = 20;
            lbl_FC_Fecha.Text = "Fecha";
            // 
            // lbl_FC_Hora
            // 
            lbl_FC_Hora.AutoSize = true;
            lbl_FC_Hora.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            lbl_FC_Hora.Location = new Point(841, 113);
            lbl_FC_Hora.Name = "lbl_FC_Hora";
            lbl_FC_Hora.Size = new Size(38, 20);
            lbl_FC_Hora.TabIndex = 21;
            lbl_FC_Hora.Text = "Hora";
            // 
            // lbl_FC_MostrarFecha
            // 
            lbl_FC_MostrarFecha.AutoSize = true;
            lbl_FC_MostrarFecha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_FC_MostrarFecha.Location = new Point(893, 86);
            lbl_FC_MostrarFecha.Name = "lbl_FC_MostrarFecha";
            lbl_FC_MostrarFecha.Size = new Size(79, 15);
            lbl_FC_MostrarFecha.TabIndex = 22;
            lbl_FC_MostrarFecha.Text = "MostrarFecha";
            // 
            // lbl_FC_MostrarHora
            // 
            lbl_FC_MostrarHora.AutoSize = true;
            lbl_FC_MostrarHora.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_FC_MostrarHora.Location = new Point(893, 118);
            lbl_FC_MostrarHora.Name = "lbl_FC_MostrarHora";
            lbl_FC_MostrarHora.Size = new Size(74, 15);
            lbl_FC_MostrarHora.TabIndex = 23;
            lbl_FC_MostrarHora.Text = "MostrarHora";
            // 
            // gbox_FC_Lista
            // 
            gbox_FC_Lista.Controls.Add(lbl_FC_Buscar);
            gbox_FC_Lista.Controls.Add(tbox_FC_Buscar);
            gbox_FC_Lista.Controls.Add(DG_F_Cliente);
            gbox_FC_Lista.Location = new Point(12, 331);
            gbox_FC_Lista.Name = "gbox_FC_Lista";
            gbox_FC_Lista.Size = new Size(984, 386);
            gbox_FC_Lista.TabIndex = 25;
            gbox_FC_Lista.TabStop = false;
            gbox_FC_Lista.Text = "Lista";
            // 
            // lbl_FC_Buscar
            // 
            lbl_FC_Buscar.AutoSize = true;
            lbl_FC_Buscar.Font = new Font("Segoe UI", 9F);
            lbl_FC_Buscar.Location = new Point(10, 38);
            lbl_FC_Buscar.Name = "lbl_FC_Buscar";
            lbl_FC_Buscar.Size = new Size(42, 15);
            lbl_FC_Buscar.TabIndex = 27;
            lbl_FC_Buscar.Text = "Buscar";
            // 
            // tbox_FC_Buscar
            // 
            tbox_FC_Buscar.Location = new Point(58, 35);
            tbox_FC_Buscar.Name = "tbox_FC_Buscar";
            tbox_FC_Buscar.Size = new Size(249, 23);
            tbox_FC_Buscar.TabIndex = 26;
            tbox_FC_Buscar.TextChanged += tbox_FC_Buscar_TextChanged;
            // 
            // DG_F_Cliente
            // 
            DG_F_Cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_F_Cliente.Location = new Point(11, 64);
            DG_F_Cliente.Name = "DG_F_Cliente";
            DG_F_Cliente.Size = new Size(961, 321);
            DG_F_Cliente.TabIndex = 25;
            DG_F_Cliente.CellClick += DG_F_Cliente_CellClick;
            // 
            // F_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            ControlBox = false;
            Controls.Add(gbox_FC_Lista);
            Controls.Add(lbl_FC_MostrarHora);
            Controls.Add(lbl_FC_MostrarFecha);
            Controls.Add(lbl_FC_Hora);
            Controls.Add(lbl_FC_Fecha);
            Controls.Add(gbox_FC_Datos);
            Controls.Add(btn_FC_Limpiar);
            Controls.Add(btn_FC_Volver);
            Controls.Add(tbox_FC_Id);
            Controls.Add(txt_FC_Id);
            Controls.Add(btn_FC_Eliminar);
            Controls.Add(btn_FC_Modificar);
            Controls.Add(btn_FC_Cargar);
            Controls.Add(lbl_FC_TituloP);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "F_Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador de clientes";
            Load += F_Cliente_Load;
            gbox_FC_Datos.ResumeLayout(false);
            gbox_FC_Datos.PerformLayout();
            gbox_FC_Lista.ResumeLayout(false);
            gbox_FC_Lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DG_F_Cliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_FC_TituloP;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btn_FC_Cargar;
        private Button btn_FC_Modificar;
        private Button btn_FC_Eliminar;
        private Label txt_FC_Id;
        private TextBox tbox_FC_Id;
        private Button btn_FC_Volver;
        private Button btn_FC_Limpiar;
        private GroupBox gbox_FC_Datos;
        private TextBox tbox_FC_Nombre;
        private Label txt_FC_Direccion;
        private TextBox tbox_FC_Direccion;
        private TextBox tbox_FC_Email;
        private TextBox tbox_FC_DNI;
        private TextBox tbox_FC_Apellido;
        private Label txt_FC_Email;
        private Label txt_FC_DNI;
        private Label txt_FC_Apellido;
        private Label txt_FC_Nombre;
        private Label lbl_FC_Fecha;
        private Label lbl_FC_Hora;
        private Label lbl_FC_MostrarFecha;
        private Label lbl_FC_MostrarHora;
        private GroupBox gbox_FC_Lista;
        private Label lbl_FC_Buscar;
        private TextBox tbox_FC_Buscar;
        private DataGridView DG_F_Cliente;
    }
}