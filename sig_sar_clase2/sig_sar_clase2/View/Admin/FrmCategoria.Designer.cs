namespace sig_sar_clase2.View.Admin
{
    partial class FrmCategoria
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
            lblCategoria = new Label();
            txtNombreCat = new TextBox();
            lblDescripcion = new Label();
            txtCategoriaCat = new TextBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            dgvTableCategoria = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTableCategoria).BeginInit();
            SuspendLayout();
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(65, 52);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(64, 20);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Nombre";
            // 
            // txtNombreCat
            // 
            txtNombreCat.Location = new Point(65, 76);
            txtNombreCat.Margin = new Padding(3, 4, 3, 4);
            txtNombreCat.Name = "txtNombreCat";
            txtNombreCat.Size = new Size(479, 27);
            txtNombreCat.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(79, 159);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtCategoriaCat
            // 
            txtCategoriaCat.Location = new Point(74, 201);
            txtCategoriaCat.Margin = new Padding(3, 4, 3, 4);
            txtCategoriaCat.Name = "txtCategoriaCat";
            txtCategoriaCat.Size = new Size(470, 27);
            txtCategoriaCat.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(192, 255, 192);
            btnRegistrar.Location = new Point(631, 76);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(86, 31);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 224, 192);
            btnLimpiar.Location = new Point(631, 197);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // dgvTableCategoria
            // 
            dgvTableCategoria.AllowUserToAddRows = false;
            dgvTableCategoria.AllowUserToDeleteRows = false;
            dgvTableCategoria.AllowUserToResizeColumns = false;
            dgvTableCategoria.AllowUserToResizeRows = false;
            dgvTableCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTableCategoria.Location = new Point(79, 259);
            dgvTableCategoria.Margin = new Padding(3, 4, 3, 4);
            dgvTableCategoria.Name = "dgvTableCategoria";
            dgvTableCategoria.RowHeadersWidth = 51;
            dgvTableCategoria.Size = new Size(605, 305);
            dgvTableCategoria.TabIndex = 6;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 600);
            Controls.Add(dgvTableCategoria);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCategoriaCat);
            Controls.Add(lblDescripcion);
            Controls.Add(txtNombreCat);
            Controls.Add(lblCategoria);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            Load += FrmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTableCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoria;
        private TextBox txtNombreCat;
        private Label lblDescripcion;
        private TextBox txtCategoriaCat;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private DataGridView dgvTableCategoria;
    }
}