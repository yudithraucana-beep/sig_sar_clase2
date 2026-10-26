using System;
using System.Collections.Generic;
using System.Text;
using sig_sar_clase2.DAO;
using sig_sar_clase2.Model;

namespace sig_sar_clase2.Controller
{
    public class CategoriaController

    {
        private readonly CategoriaDAO categoriaDAO = new CategoriaDAO();

        public List<Categoria> ListaCategorias()
        {
            return categoriaDAO.tablaCategorias();
        }
    }
}
