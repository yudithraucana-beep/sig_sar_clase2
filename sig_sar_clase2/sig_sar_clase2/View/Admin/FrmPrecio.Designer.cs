namespace sig_sar_clase2.View.Admin
{
    partial class FrmPrecio
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
            btnAceptar = new Button();
            btnIliminar = new Button();
            lblProducto = new Label();
            txtProducto = new TextBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 42);
            label1.Name = "label1";
            label1.Size = new Size(118, 41);
            label1.TabIndex = 0;
            label1.Text = "Precios";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(547, 151);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnIliminar
            // 
            btnIliminar.Location = new Point(547, 248);
            btnIliminar.Name = "btnIliminar";
            btnIliminar.Size = new Size(94, 29);
            btnIliminar.TabIndex = 2;
            btnIliminar.Text = "Iliminar";
            btnIliminar.UseVisualStyleBackColor = true;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(43, 107);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(69, 20);
            lblProducto.TabIndex = 3;
            lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(33, 130);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(400, 27);
            txtProducto.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 209);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 5;
            label2.Text = "Cantidad";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(130, 209);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(258, 27);
            numericUpDown1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 270);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "Precio";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 274);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 27);
            textBox1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(88, 325);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(602, 170);
            dataGridView1.TabIndex = 9;
            // 
            // FrmPrecio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 507);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(txtProducto);
            Controls.Add(lblProducto);
            Controls.Add(btnIliminar);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Name = "FrmPrecio";
            Text = "FrmPrecio";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAceptar;
        private Button btnIliminar;
        private Label lblProducto;
        private TextBox txtProducto;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}