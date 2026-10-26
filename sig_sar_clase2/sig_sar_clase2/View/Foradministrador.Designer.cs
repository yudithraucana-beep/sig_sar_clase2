namespace sig_sar_clase2
{
    partial class Foradministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foradministrador));
            toolStrip1 = new ToolStrip();
            btnMenuUsuario = new ToolStripSplitButton();
            toolStripSplitButton2 = new ToolStripSplitButton();
            toolStripSplitButton1 = new ToolStripSplitButton();
            btnMenuCategoria = new ToolStripSplitButton();
            toolStripSplitButton4 = new ToolStripSplitButton();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnMenuUsuario, toolStripSplitButton2, toolStripSplitButton1, btnMenuCategoria, toolStripSplitButton4 });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(838, 47);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnMenuUsuario
            // 
            btnMenuUsuario.Image = (Image)resources.GetObject("btnMenuUsuario.Image");
            btnMenuUsuario.ImageTransparentColor = Color.Magenta;
            btnMenuUsuario.Name = "btnMenuUsuario";
            btnMenuUsuario.Size = new Size(82, 44);
            btnMenuUsuario.Text = "usuarios";
            btnMenuUsuario.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMenuUsuario.ToolTipText = "usuario";
            btnMenuUsuario.ButtonClick += usuario_ButtonClick;
            // 
            // toolStripSplitButton2
            // 
            toolStripSplitButton2.Image = (Image)resources.GetObject("toolStripSplitButton2.Image");
            toolStripSplitButton2.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton2.Name = "toolStripSplitButton2";
            toolStripSplitButton2.Size = new Size(64, 44);
            toolStripSplitButton2.Text = "Roles";
            toolStripSplitButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripSplitButton2.ButtonClick += toolStripSplitButton2_ButtonClick;
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(94, 44);
            toolStripSplitButton1.Text = "Productos";
            toolStripSplitButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripSplitButton1.ButtonClick += toolStripSplitButton1_ButtonClick;
            // 
            // btnMenuCategoria
            // 
            btnMenuCategoria.Image = (Image)resources.GetObject("btnMenuCategoria.Image");
            btnMenuCategoria.ImageTransparentColor = Color.Magenta;
            btnMenuCategoria.Name = "btnMenuCategoria";
            btnMenuCategoria.Size = new Size(99, 44);
            btnMenuCategoria.Text = "Categorias";
            btnMenuCategoria.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMenuCategoria.ButtonClick += btnMenuCategoria_ButtonClick;
            // 
            // toolStripSplitButton4
            // 
            toolStripSplitButton4.Image = (Image)resources.GetObject("toolStripSplitButton4.Image");
            toolStripSplitButton4.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton4.Name = "toolStripSplitButton4";
            toolStripSplitButton4.Size = new Size(75, 44);
            toolStripSplitButton4.Text = "Precios";
            toolStripSplitButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripSplitButton4.ButtonClick += toolStripSplitButton4_ButtonClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(123, 191);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 196);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 148);
            label2.Name = "label2";
            label2.Size = new Size(447, 20);
            label2.TabIndex = 2;
            label2.Text = "Sistema Integral de Servicios Administrador para Restaurantes";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(99, 17);
            label1.Name = "label1";
            label1.Size = new Size(320, 106);
            label1.TabIndex = 0;
            label1.Text = "SIGSAR";
            // 
            // Foradministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(838, 623);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Foradministrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modulo Administrador";
            Load += Foradministrador_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripSplitButton btnMenuUsuario;
        private ToolStripSplitButton toolStripSplitButton2;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripSplitButton btnMenuCategoria;
        private ToolStripSplitButton toolStripSplitButton4;
        private Panel panel1;
        private Label label1;
        private Label label2;
    }
}