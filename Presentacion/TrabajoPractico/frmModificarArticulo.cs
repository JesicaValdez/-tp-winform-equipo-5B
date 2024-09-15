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
    public partial class frmModificarArticulo : Form
    {
        private List<Articulo> listaArticulos;
        public frmModificarArticulo()
        {
            InitializeComponent();
        }

        private void frmModificarArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listarArticulos();
            dgv_modificarArticulo.DataSource = listaArticulos;
            dgv_modificarArticulo.Columns["Id"].Visible = false;
            dgv_modificarArticulo.Columns["ImagenUrl"].Visible = false;
            cargarimagen(listaArticulos[0].imagenurl);

        }

        private void cargarimagen(string imagen)
        {

            try
            {
                pb_actual.Load(imagen);
            }
            catch (Exception)
            {
                pb_actual.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRRCZVKWKAUmqHUszu8_M3CoepdRNIXk9SvZQ&s");
            }
        }

        private void cargarimagen2(string imagen)
        {

            try
            {
                pb_Modificado.Load(imagen);
            }
            catch (Exception)
            {
                pb_Modificado.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRRCZVKWKAUmqHUszu8_M3CoepdRNIXk9SvZQ&s");
            }
        }

        private void dgv_modificarArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_modificarArticulo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgv_modificarArticulo.CurrentRow.DataBoundItem;
                
                txtBox_codigo.Text = seleccionado.codigo;
                txtBox_nombre.Text = seleccionado.nombre;
                txtBox_descripcion.Text = seleccionado.descripcion;
                cBox_marca.Text = seleccionado.marca.Descripcion;
                cBox_categoria.Text = seleccionado.categoria.Descripcion;
                txtBox_precio.Text = seleccionado.precio.ToString();
                txtBox_UrlImagen.Text = seleccionado.imagenurl;
                
                try
                {
                    pb_actual.Load(seleccionado.imagenurl);
                }
                catch
                {
                    pb_actual.Image = null;
                }
                
            }

        }

        private bool ValidarCampos()
        {
            
            if (txtBox_descripcion.Text.Length > 150)
            {
                MessageBox.Show("La descripcion del articulo no puede superar los 150 caracteres, intente nuevamente.");
                return true;
            }
            if (!decimal.TryParse(txtBox_precio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número");
                return true;
            }
            return false;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (dgv_modificarArticulo.CurrentRow == null)
            {
                MessageBox.Show("No hay una fila seleccionada para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarCampos())
            {
                return;
            }

            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo articulo = new Articulo();
            
            if (dgv_modificarArticulo.CurrentRow != null)
            {
                articulo.codigo = txtBox_codigo.Text;
                articulo.nombre = txtBox_nombre.Text;
                articulo.descripcion = txtBox_descripcion.Text;
                articulo.marca = (Marca)cBox_marca.SelectedItem;
                articulo.categoria = (Categoria)cBox_categoria.SelectedItem;
                articulo.precio = decimal.Parse(txtBox_precio.Text);
                articulo.id = ((Articulo)dgv_modificarArticulo.CurrentRow.DataBoundItem).id;
                articulo.imagenurl = txtBox_UrlImagen.Text;


                negocio.modificarArticulo(articulo);
                listaArticulos = negocio.listarArticulos();
                dgv_modificarArticulo.DataSource = listaArticulos;
                cargarimagen2(articulo.imagenurl);
            }

        }

            
    }
}

