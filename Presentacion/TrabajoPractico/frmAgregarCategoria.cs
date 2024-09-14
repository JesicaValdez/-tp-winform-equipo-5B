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
    public partial class frm_AgregarCategoria : Form
    {
        private List<Categoria> listaCategorias;
        public frm_AgregarCategoria()
        {
            InitializeComponent();
        }

        private void frm_AgregarCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            listaCategorias = negocio.ListarCategorias();
            dgv_categoriaAgregada.DataSource = listaCategorias;

        }

        private void dgv_categoriaAgregada_SelectionChanged(object sender, EventArgs e)
        {
            Categoria categoriaSeleccionada = (Categoria)dgv_categoriaAgregada.CurrentRow.DataBoundItem;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria categoria = new Categoria();
            categoria.Descripcion = txt_categoria.Text;
            negocio.agregarCategoria(categoria);
            listaCategorias = negocio.ListarCategorias();
            dgv_categoriaAgregada.DataSource = listaCategorias;
            txt_categoria.Text = "";

            MessageBox.Show("Categoria agregada correctamente");

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
