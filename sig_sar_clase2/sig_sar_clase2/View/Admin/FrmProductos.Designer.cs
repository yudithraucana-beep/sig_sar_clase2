namespace sig_sar_clase2.View.Admin
{
    partial class FrmProductos
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            btnIliminar = new Button();
            dgvTableProducto = new DataGridView();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTableProducto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 29);
            label1.Name = "label1";
            label1.Size = new Size(160, 41);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 116);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo de producto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 27);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 206);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 3;
            label3.Text = "Descripcion";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(40, 250);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 55);
            textBox2.TabIndex = 4;
            // 
            // btnIliminar
            // 
            btnIliminar.BackColor = Color.FromArgb(255, 192, 192);
            btnIliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIliminar.Location = new Point(396, 262);
            btnIliminar.Name = "btnIliminar";
            btnIliminar.Size = new Size(94, 29);
            btnIliminar.TabIndex = 6;
            btnIliminar.Text = "Iliminar";
            btnIliminar.UseVisualStyleBackColor = false;
            // 
            // dgvTableProducto
            // 
            dgvTableProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTableProducto.Location = new Point(40, 341);
            dgvTableProducto.Name = "dgvTableProducto";
            dgvTableProducto.RowHeadersWidth = 51;
            dgvTableProducto.Size = new Size(516, 156);
            dgvTableProducto.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(396, 156);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 509);
            Controls.Add(btnAgregar);
            Controls.Add(dgvTableProducto);
            Controls.Add(btnIliminar);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProductos";
            Text = "FrmProductos";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTableProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private Button btnIliminar;
        private DataGridView dgvTableProducto;
        private Button btnAgregar;
    }
}