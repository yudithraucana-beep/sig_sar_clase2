using System;
using System.Windows.Forms;
using Npgsql;
using sig_sar_clase2.Config;
using sig_sar_clase2.Model;


namespace sig_sar_clase2.DAO
{
    public class CategoriaDAO
    {
        // INSERTAR CATEGORIA
        public bool InsertarCategoria(Categoria categoria)
        {
            try
            {
                using (NpgsqlConnection cn = ConexionDB.ObtenerConexionDB())
                {
                    cn.Open();
                    string sql = @"INSERT INTO categoria (nombre, descripcion) VALUES (@nombre, @descripcion);";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
                        cmd.Parameters.AddWithValue("@descripcion", categoria.Descripcion);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // ACTUALIZAR CATEGORIA
        public bool ActualizarCategoria(Categoria categoria)
        {
            try
            {
                using (NpgsqlConnection cn = ConexionDB.ObtenerConexionDB())
                {
                    cn.Open();
                    string sql = @"UPDATE categoria 
                                   SET nombre = @nombre, 
                                       descripcion = @descripcion 
                                   WHERE idcategoria = @idcategoria;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
                        cmd.Parameters.AddWithValue("@descripcion", categoria.Descripcion);
                        cmd.Parameters.AddWithValue("@idcategoria", categoria.IdCategoria);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // ELIMINAR CATEGORIA
        public bool EliminarCategoria(int IdCategoria)
        {
            try
            {
                using (NpgsqlConnection cn = ConexionDB.ObtenerConexionDB())
                {
                    cn.Open();

                    string sql = @"DELETE FROM categoria 
                                   WHERE idcategoria = @idcategoria;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@idcategoria", IdCategoria);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Categoria> tablaCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            try
            {
                using (NpgsqlConnection cn = ConexionDB.ObtenerConexionDB())
                {
                    cn.Open();

                    string sql = @"SELECT id_categoria, nombre, descripcion 
                                   FROM categoria 
                                   ORDER BY id_categoria ASC;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Categoria cat = new Categoria();

                                cat.IdCategoria = Convert.ToInt32(dr["id_categoria"]);
                                cat.Nombre = dr["nombre"].ToString();
                                cat.Descripcion = dr["descripcion"].ToString();

                                lista.Add(cat);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar categorias: " + ex.Message);
            }

            return lista;
        }
    }
}