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
            Articulo seleccionado = (Articulo)dgvBuscarMarca.CurrentRow.DataBoundItem;
            cargarimagen(seleccionado.imagenurl);
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
    }
}
