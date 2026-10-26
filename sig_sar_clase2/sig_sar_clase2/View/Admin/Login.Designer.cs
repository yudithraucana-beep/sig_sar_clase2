namespace sig_sar_clase2
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            textUsuario = new TextBox();
            textClave = new MaskedTextBox();
            label3 = new Label();
            btnIngresar = new Button();
            cbxRol = new ComboBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            lblConexionBD = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 171);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "Rol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 285);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 2;
            label2.Text = "Ususario(DNI)";
            label2.Click += label2_Click;
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(401, 345);
            textUsuario.Margin = new Padding(3, 4, 3, 4);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(214, 27);
            textUsuario.TabIndex = 3;
            // 
            // textClave
            // 
            textClave.Location = new Point(401, 481);
            textClave.Margin = new Padding(3, 4, 3, 4);
            textClave.Name = "textClave";
            textClave.PasswordChar = '*';
            textClave.Size = new Size(214, 27);
            textClave.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 409);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            label3.Click += label3_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(192, 255, 192);
            btnIngresar.ForeColor = SystemColors.InfoText;
            btnIngresar.Location = new Point(542, 589);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(97, 55);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += button1_Click;
            // 
            // cbxRol
            // 
            cbxRol.FormattingEnabled = true;
            cbxRol.Items.AddRange(new object[] { "Administrador", "Chef", "Mozo" });
            cbxRol.Location = new Point(401, 227);
            cbxRol.Margin = new Padding(3, 4, 3, 4);
            cbxRol.Name = "cbxRol";
            cbxRol.Size = new Size(214, 28);
            cbxRol.TabIndex = 8;
            cbxRol.SelectedIndexChanged += cbxRol_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(391, 589);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(113, 55);
            button1.TabIndex = 10;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images1;
            pictureBox1.Location = new Point(54, 171);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 473);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(263, 61);
            label4.Name = "label4";
            label4.Size = new Size(205, 37);
            label4.TabIndex = 12;
            label4.Text = "LOGIN-SIGSAR";
            // 
            // lblConexionBD
            // 
            lblConexionBD.AutoSize = true;
            lblConexionBD.Location = new Point(14, 12);
            lblConexionBD.Name = "lblConexionBD";
            lblConexionBD.Size = new Size(18, 20);
            lblConexionBD.TabIndex = 13;
            lblConexionBD.Text = "...";
            lblConexionBD.Click += lblConexionBD_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(758, 676);
            Controls.Add(lblConexionBD);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(cbxRol);
            Controls.Add(btnIngresar);
            Controls.Add(label3);
            Controls.Add(textClave);
            Controls.Add(textUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            Text = "Login sig_sar";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textUsuario;
        private MaskedTextBox textClave;
        private Label label3;
        private Button btnIngresar;
        private PictureBox login;
        private ComboBox cbxRol;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label lblConexionBD;
    }
}
