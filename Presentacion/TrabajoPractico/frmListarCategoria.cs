using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Manager;

namespace TrabajoPractico
{
    public partial class frmListarCategoria : Form
    {
        
        private List<Categoria> categoriasLista;

        public frmListarCategoria()
        {
            InitializeComponent();
        }

        private void frmListarCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                categoriasLista = negocio.ListarCategorias();
                dgv_ListCat.DataSource = categoriasLista;
                dgv_ListCat.Columns["Id"].Visible = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_ListarCategorias_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
