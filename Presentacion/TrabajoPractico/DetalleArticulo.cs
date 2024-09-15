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
    public partial class DetalleArticulo : Form
    {
        private List<Articulo> soloName;
        public DetalleArticulo()
        {
            InitializeComponent();
        }

        private void DetalleArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            soloName = negocio.listarArticulos();
            dgv_list.DataSource = soloName;
            dgv_list.Columns["Id"].Visible = false;
            dgv_list.Columns["Codigo"].Visible = false;
            dgv_list.Columns["Categoria"].Visible = false;
            dgv_list.Columns["Marca"].Visible = false;
            dgv_list.Columns["Precio"].Visible = false;
            dgv_list.Columns["Descripcion"].Visible = false;
            dgv_list.Columns["ImagenUrl"].Visible = false;
            cargarimagen(soloName[0].imagenurl);
            pbox_oculta.Visible = false;
        }

        private void cargarimagen(string imagen)
        {
            try
            {
                pbox_oculta.Load(imagen);
            }
            catch (Exception)
            {
                pbox_oculta.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRRCZVKWKAUmqHUszu8_M3CoepdRNIXk9SvZQ&s");
            }
        }

        private void dgv_list_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgv_list.CurrentRow.DataBoundItem;
            cargarimagen(seleccionado.imagenurl);
        }

        private void btn_detalleItem_Click(object sender, EventArgs e)
        {
            Articulo mostrar;
            if (dgv_list.CurrentRow != null)
            {
                mostrar = (Articulo)dgv_list.CurrentRow.DataBoundItem;
                Detalle ventana = new Detalle(mostrar);
                ventana.ShowDialog();
            }
            else
            {
                MessageBox.Show("No selecciono ningun articulo");
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
