using System;
using System.Windows.Forms;
using sig_sar_clase2.Model;
using sig_sar_clase2.DAO; 

namespace sig_sar_clase2.View.Admin
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            
        }
        private void btlRegistrarCat_Load(object sender, EventArgs e)
        {
            if (txtNombreCat.Text != "")
            {
                MessageBox.Show("Categoria Registrada");
            }
        }

        
        
        private void txtNombreCat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}