namespace FrontEnd
{
    partial class F_P
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
            lbl_FP_TituloP = new Label();
            Btn_FP_Clientes = new Button();
            Btn_FP_Libros = new Button();
            SuspendLayout();
            // 
            // lbl_FP_TituloP
            // 
            lbl_FP_TituloP.AutoSize = true;
            lbl_FP_TituloP.Font = new Font("Script MT Bold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_FP_TituloP.Location = new Point(168, 92);
            lbl_FP_TituloP.Name = "lbl_FP_TituloP";
            lbl_FP_TituloP.Size = new Size(378, 58);
            lbl_FP_TituloP.TabIndex = 0;
            lbl_FP_TituloP.Text = "BIENVENIDOS";
            lbl_FP_TituloP.Click += BIENVENIDOS_Click;
            // 
            // Btn_FP_Clientes
            // 
            Btn_FP_Clientes.Font = new Font("Rockwell", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_FP_Clientes.Location = new Point(168, 262);
            Btn_FP_Clientes.Name = "Btn_FP_Clientes";
            Btn_FP_Clientes.Size = new Size(144, 64);
            Btn_FP_Clientes.TabIndex = 1;
            Btn_FP_Clientes.Text = "Clientes";
            Btn_FP_Clientes.UseVisualStyleBackColor = true;
            Btn_FP_Clientes.Click += Btn_FP_Clientes_Click;
            // 
            // Btn_FP_Libros
            // 
            Btn_FP_Libros.Font = new Font("Rockwell", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_FP_Libros.Location = new Point(396, 262);
            Btn_FP_Libros.Name = "Btn_FP_Libros";
            Btn_FP_Libros.Size = new Size(150, 64);
            Btn_FP_Libros.TabIndex = 2;
            Btn_FP_Libros.Text = "Libros";
            Btn_FP_Libros.UseVisualStyleBackColor = true;
            Btn_FP_Libros.Click += Btn_FP_Libros_Click;
            // 
            // F_P
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_FP_Libros);
            Controls.Add(Btn_FP_Clientes);
            Controls.Add(lbl_FP_TituloP);
            Name = "F_P";
            Text = "F_P";
            Load += F_P_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_FP_TituloP;
        private Button Btn_FP_Clientes;
        private Button Btn_FP_Libros;
    }
}