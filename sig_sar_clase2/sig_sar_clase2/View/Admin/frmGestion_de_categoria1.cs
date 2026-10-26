using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql; // Importante: Manejador de PostgreSQL

namespace sig_sar_clase2.View.Admin
{
    public partial class frmGestion_de_categoria1 : Form
    {
        // ----------------------------------------------------------------------------------
        // 1. CADENA DE CONEXIÓN
        // Cambia localhost, el puerto, nombre de BD, usuario y contraseña por los tuyos.
        // ----------------------------------------------------------------------------------
        private string cadenaConexion = @"Host=localhost;Port=5432;Database=sig_sar_clase2;Username=postgres;Password=admin123;";

        public frmGestion_de_categoria1()
        {
            InitializeComponent();
        }

        // ----------------------------------------------------------------------------------
        // 2. EVENTO LOAD (Al abrir el formulario)
        // ----------------------------------------------------------------------------------
        private void frmGestion_de_categoria1_Load(object sender, EventArgs e)
        {
            ListarCategorias();
        }

        // ----------------------------------------------------------------------------------
        // 3. MÉTODO PARA LISTAR CATEGORÍAS EN EL DATAGRIDVIEW
        // ----------------------------------------------------------------------------------
        private void ListarCategorias()
        {
            try
            {
                using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
                {
                    // Consulta SQL que obtiene id, nombre y estado
                    string sql = "SELECT id_categoria AS \"ID\", nombre AS \"Nombre de Categoría\", estado AS \"Estado\" " +
                                 "FROM categoria WHERE estado = true ORDER BY id_categoria DESC";

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Reemplaza 'dataGridView1' si tu DataGridView tiene otro nombre
                    dataGridView1.DataSource = dt;

                    // Ajuste estético opcional de columnas
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------------------------------------------------
        // 4. CÓDIGO PARA EL BOTÓN "REGISTRAR"
        // ----------------------------------------------------------------------------------
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar que el campo no esté vacío o con espacios en blanco
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ingresa el nombre de la categoría antes de registrar.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            // Validar que no supere los 35 caracteres (VARCHAR(35) en la BD)
            if (textBox1.Text.Trim().Length > 35)
            {
                MessageBox.Show("El nombre no puede superar los 35 caracteres.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
                {
                    // Inserción parametrizada para evitar inyección SQL
                    string sql = "INSERT INTO categoria (nombre, estado) VALUES (@nombre, true)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", textBox1.Text.Trim());

                        conexion.Open();
                        cmd.ExecuteNonQuery(); // Ejecuta la consulta sin devolver filas
                    }
                }

                MessageBox.Show("¡Categoría registrada exitosamente!",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar la caja de texto y actualizar el DataGridView
                textBox1.Clear();
                textBox1.Focus();
                ListarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la categoría: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------------------------------------------------
        // 5. CÓDIGO PARA EL BOTÓN "ELIMINAR" (Borrado Lógico)
        // ----------------------------------------------------------------------------------
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validar que haya al menos una fila seleccionada en la lista
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el ID y el nombre de la fila seleccionada
                int idCategoria = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                string nombreCat = dataGridView1.SelectedRows[0].Cells["Nombre de Categoría"].Value.ToString();

                // Confirmación antes de eliminar
                DialogResult dialogo = MessageBox.Show($"¿Estás seguro de desactivar/eliminar la categoría '{nombreCat}'?",
                                                       "Confirmar Eliminación",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);

                if (dialogo == DialogResult.Yes)
                {
                    try
                    {
                        using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
                        {
                            // Borrado lógico: Cambiamos estado a FALSE para mantener la integridad
                            string sql = "UPDATE categoria SET estado = false WHERE id_categoria = @id";

                            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conexion))
                            {
                                cmd.Parameters.AddWithValue("@id", idCategoria);

                                conexion.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Categoría eliminada con éxito.",
                                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListarCategorias();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la categoría: " + ex.Message,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila del cuadro para eliminar.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
