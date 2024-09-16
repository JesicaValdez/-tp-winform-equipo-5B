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
    public partial class frmBuscarporMarca : Form
    {
        private string imagenactual = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRRCZVKWKAUmqHUszu8_M3CoepdRNIXk9SvZQ&s";
        public frmBuscarporMarca()
        {
            InitializeComponent();
        }

        private void frmBuscarporMarca_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            List<Marca> lista = negocio.ListarMarcas();
            foreach (Marca marca in lista)
            {
                cboMarca.Items.Add(marca.Descripcion);
            }
        }

        private void cboMarca_SelectedValueChanged(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvBuscarMarca.DataSource = negocio.buscarpormarca(cboMarca.SelectedItem.ToString());
        }

        private void dgvBuscarMarca_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBuscarMarca.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvBuscarMarca.CurrentRow.DataBoundItem;
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
                pbxMarca.Load(imagen);
            }
            catch (Exception)
            {
                pbxMarca.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRRCZVKWKAUmqHUszu8_M3CoepdRNIXk9SvZQ&s");
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvBuscarMarca.CurrentRow.DataBoundItem;
            ImagenNegocio negocio = new ImagenNegocio();
            List<Imagen> lista = negocio.buscarimagenes(seleccionado.id);
            for (int i = 0; i < lista.Count - 1; i++)
            {
                if (lista[i].Url == imagenactual)
                    pbxMarca.Load(lista[i + 1].Url);
            }
        }
    }
}
