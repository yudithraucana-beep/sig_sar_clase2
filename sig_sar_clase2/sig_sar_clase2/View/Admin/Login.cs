using Npgsql;
using sig_sar_clase2.Config;

namespace sig_sar_clase2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection conexion = ConexionDB.ObtenerConexionDB())
                conexion.Open();
            try
            {
                lblConexionBD.Text = "Conexión  exitosa";
                lblConexionBD.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblConexionBD.Text = "Error al conectar";
                lblConexionBD.ForeColor = Color.Red;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al Sistema SIG SAR", "Mensaje");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblConexionBD_Click(object sender, EventArgs e)
        {

        }
    }
}
