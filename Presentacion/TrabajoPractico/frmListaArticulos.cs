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
        public frmListaArticulos()
        {
            InitializeComponent();
        }

        private void frmListaArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaarticulos = negocio.listarArticulos();
            dgvArticulos.DataSource = listaarticulos;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            cargarimagen(listaarticulos[0].imagenurl);
        }

        private void cargarimagen(string imagen)
        {
            try
            {
                pbxArticulos.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulos.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRRCZVKWKAUmqHUszu8_M3CoepdRNIXk9SvZQ&s");
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarimagen(seleccionado.imagenurl);
        }
    }
}
