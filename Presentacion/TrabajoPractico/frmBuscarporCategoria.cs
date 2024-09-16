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
        private string imagenactual = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRRCZVKWKAUmqHUszu8_M3CoepdRNIXk9SvZQ&s";
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
            if (dgvBuscarCat.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvBuscarCat.CurrentRow.DataBoundItem;
                ImagenNegocio negocio = new ImagenNegocio();
                List<Imagen> lista = negocio.buscarimagenes(seleccionado.id);
                cargarimagen(lista[0].Url);
                imagenactual = lista[0].Url;
            }
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

        private void botonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvBuscarCat.CurrentRow.DataBoundItem;
            ImagenNegocio negocio = new ImagenNegocio();
            List<Imagen> lista = negocio.buscarimagenes(seleccionado.id);
            for (int i = 0; i < lista.Count - 1; i++)
            {
                if (lista[i].Url == imagenactual)
                    pbxCat.Load(lista[i + 1].Url);
            }
        }
    }
}
