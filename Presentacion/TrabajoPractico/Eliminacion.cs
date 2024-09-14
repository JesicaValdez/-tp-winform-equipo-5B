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
    public partial class Eliminacion : Form
    {
        private List<Articulo> eliminar;
        public Eliminacion()
        {
            InitializeComponent();
        }

        private void Eliminacion_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            eliminar = negocio.listarArticulos();
            dgv_eliminar.DataSource = eliminar;
            dgv_eliminar.Columns["Id"].Visible = false;
            dgv_eliminar.Columns["ImagenUrl"].Visible = false;
            cargarimagen(eliminar[0].imagenurl);
        }

        private void cargarimagen(string imagen)
        {
            try
            {
                pbox_elimiar.Load(imagen);
            }
            catch (Exception)
            {
                pbox_elimiar.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRRCZVKWKAUmqHUszu8_M3CoepdRNIXk9SvZQ&s");
            }
        }

        private void dgv_eliminar_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgv_eliminar.CurrentRow.DataBoundItem;
            cargarimagen(seleccionado.imagenurl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionada;

            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro desea elminar la marca?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionada = (Articulo)dgv_eliminar.CurrentRow.DataBoundItem;
                    negocio.eliminarArticulo(seleccionada.id);
                    Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
