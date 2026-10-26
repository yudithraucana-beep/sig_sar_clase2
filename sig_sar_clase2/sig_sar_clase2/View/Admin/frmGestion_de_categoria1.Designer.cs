namespace sig_sar_clase2.View.Admin
{
    partial class frmGestion_de_categoria1
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
            dataGridView1 = new DataGridView();
            lblRegistrar = new Button();
            lblEliminar = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 212);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(671, 188);
            dataGridView1.TabIndex = 2;
            // 
            // lblRegistrar
            // 
            lblRegistrar.BackColor = Color.FromArgb(128, 255, 128);
            lblRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistrar.ForeColor = SystemColors.ActiveCaptionText;
            lblRegistrar.Location = new Point(501, 116);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(94, 52);
            lblRegistrar.TabIndex = 3;
            lblRegistrar.Text = "Registrar";
            lblRegistrar.UseVisualStyleBackColor = false;
            // 
            // lblEliminar
            // 
            lblEliminar.BackColor = Color.FromArgb(255, 128, 128);
            lblEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEliminar.Location = new Point(653, 116);
            lblEliminar.Name = "lblEliminar";
            lblEliminar.Size = new Size(94, 52);
            lblEliminar.TabIndex = 4;
            lblEliminar.Text = "Eliminar";
            lblEliminar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(343, 48);
            label1.Name = "label1";
            label1.Size = new Size(208, 28);
            label1.TabIndex = 6;
            label1.Text = "Gestion de categoria";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(358, 27);
            textBox1.TabIndex = 7;
            // 
            // frmGestion_de_categoria1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lblEliminar);
            Controls.Add(lblRegistrar);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGestion_de_categoria1";
            Text = "frmGestion_de_categoria1";
            Load += frmGestion_de_categoria1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button lblRegistrar;
        private Button lblEliminar;
        private Label label1;
        private TextBox textBox1;
    }
}