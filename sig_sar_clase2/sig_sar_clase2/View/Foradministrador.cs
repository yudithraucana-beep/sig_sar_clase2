using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using sig_sar_clase2.Config;
using sig_sar_clase2.View.Admin; // Asegúrate de incluir el espacio de nombres de tus formularios

namespace sig_sar_clase2
{
    public partial class Foradministrador : Form
    {
        public Foradministrador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        // EVENTO LOAD: Muestra un mensaje de éxito o error al iniciar el formulario
        private void Foradministrador_Load(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection conexion = ConexionDB.ObtenerConexionDB())
                {
                    conexion.Open();

                    // Mensaje emergente cuando la conexión es exitosa
                    MessageBox.Show("¡Conectado exitosamente a la base de datos PostgreSQL!",
                                    "Conexión Exitosas",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Mensaje emergente si ocurre un error de conexión
                MessageBox.Show("Error al conectar con la base de datos: \n" + ex.Message,
                                "Error de Conexión",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnMenuCategoria_ButtonClick(object sender, EventArgs e)
        {
            FrmCategoria categoria = new FrmCategoria();
            categoria.ShowDialog();
        }

        private void usuario_ButtonClick(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            usuario.ShowDialog();
        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            FrmRoles roles = new FrmRoles();
            roles.ShowDialog();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            FrmProductos productos = new FrmProductos();
            productos.ShowDialog();
        }

        private void toolStripSplitButton4_ButtonClick(object sender, EventArgs e)
        {
            FrmPrecio precio = new FrmPrecio();
            precio.ShowDialog();
        }
    }
}
        
        