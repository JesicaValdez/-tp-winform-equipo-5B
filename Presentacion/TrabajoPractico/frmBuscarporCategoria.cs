using Dominio;
using Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico
{
    public partial class frmBuscarporCategoria : Form
    {
        public frmBuscarporCategoria()
        {
            InitializeComponent();
        }

        private void frmBuscarporCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            List<Categoria> lista = negocio.ListarCategorias();
            foreach (Categoria cat in lista)
            {
                cboCat.Items.Add(cat.Descripcion);
            }
        }

        private void cboCat_SelectedValueChanged(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvBuscarCat.DataSource = negocio.buscarporcategoria(cboCat.SelectedItem.ToString());
        }

        private void dgvBuscarCat_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvBuscarCat.CurrentRow.DataBoundItem;
            cargarimagen(seleccionado.imagenurl);
        }

        private void cargarimagen(string imagen)
        {
            try
            {
                pbxCat.Load(imagen);
            }
            catch (Exception)
            {
                pbxCat.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRRCZVKWKAUmqHUszu8_M3CoepdRNIXk9SvZQ&s");
            }
        }
    }
}
