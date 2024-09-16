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
    public partial class frmAgregarImagen : Form
    {
        public frmAgregarImagen()
        {
            InitializeComponent();
        }

        private void frmAgregarImagen_Load(object sender, EventArgs e)
        {
            List<Articulo> listaarticulos;
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaarticulos = negocio.listarArticulos();
            dgvArt.DataSource = listaarticulos;
            dgvArt.Columns["Id"].Visible = false;
            dgvArt.Columns["ImagenUrl"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pbxImagen.Load(tbUrl.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Imagen imagen = new Imagen();
                ImagenNegocio negocio = new ImagenNegocio();
                Articulo seleccionado = (Articulo)dgvArt.CurrentRow.DataBoundItem;
                imagen.IdArticulo = seleccionado.id;
                imagen.Url = tbUrl.Text;
                negocio.agregarImagen(imagen);
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
