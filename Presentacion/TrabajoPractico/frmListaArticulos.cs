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
    public partial class frmListaArticulos : Form
    {
        private List<Articulo> listaarticulos;
        private string imagenactual = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRRCZVKWKAUmqHUszu8_M3CoepdRNIXk9SvZQ&s";
        public frmListaArticulos()
        {
            InitializeComponent();
        }

        private void frmListaArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaarticulos = negocio.listarArticulos();
            dgvArticulos.DataSource = listaarticulos;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            cargarimagen(listaarticulos[0].imagenurl);
        }

        private void cargarimagen(string imagen)
        {
            try
            {
                pbxArticulos.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulos.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRRCZVKWKAUmqHUszu8_M3CoepdRNIXk9SvZQ&s");
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ImagenNegocio negocio = new ImagenNegocio();
                List<Imagen> lista = negocio.buscarimagenes(seleccionado.id);
                cargarimagen(lista[0].Url);
                imagenactual = lista[0].Url;
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            ImagenNegocio negocio = new ImagenNegocio();
            List<Imagen> lista = negocio.buscarimagenes(seleccionado.id);
            for (int i = 0; i < lista.Count - 1; i++)
            {
                if (lista[i].Url == imagenactual)
                    pbxArticulos.Load(lista[i + 1].Url);
            }
        }
    }
}
