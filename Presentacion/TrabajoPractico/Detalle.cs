using Dominio;
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
    public partial class Detalle : Form
    {
        private Articulo articulo;
        public Detalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void Detalle_Load(object sender, EventArgs e)
        {
            try
            {
                ListViewItem nuevo = new ListViewItem(articulo.descripcion);
                lbl_nombreA.Text = articulo.nombre;
                lbl_code.Text = articulo.codigo;
                lbl_categoria.Text = articulo.categoria.ToString();
                lbl_marca.Text = articulo.marca.ToString();
                lbl_precio.Text = "$" + articulo.precio.ToString();
                txt_descripcion.Text = articulo.descripcion;
                cargarImagen(articulo.imagenurl);
                txt_descripcion.SelectionStart = txt_descripcion.Text.Length;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string url)
        {
            try
            {
                pbox_imgA.Load(url);
            }
            catch
            {
                pbox_imgA.Load("https://i.pinimg.com/originals/6b/22/98/6b2298fec93ad8240f87c8228ab87969.jpg");
            }
        }

        private void btn_atrasDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
