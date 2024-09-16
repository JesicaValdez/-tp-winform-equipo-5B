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
    public partial class AgregarArticulo : Form
    {
        Articulo articulo = null;

        public AgregarArticulo()
        {
            InitializeComponent();
        }

        public AgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                cBox_categoria.DataSource = categoriaNegocio.ListarCategorias();
                cBox_categoria.ValueMember = "Id";
                cBox_categoria.DisplayMember = "Descripcion";
                cBox_categoria.SelectedIndex = -1;

                cBox_marca.DataSource = marcaNegocio.ListarMarcas();
                cBox_marca.ValueMember = "Id";
                cBox_marca.DisplayMember = "Descripcion";
                cBox_marca.SelectedIndex = -1;

                if(articulo != null)
                {
                    txtBox_codigo.Text = articulo.codigo;
                    txtBox_nombre.Text = articulo.nombre;
                    txtBox_descripcion.Text = articulo.descripcion;
                    txtBox_precio.Text = articulo.precio.ToString();
                    cBox_categoria.SelectedValue = articulo.categoria.Id;
                    cBox_marca.SelectedValue = articulo.marca.Id;
                    txtBox_UrlImagen.Text = articulo.imagenurl;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }



        private bool ValidarCampos()
        {
            if(txtBox_codigo.Text == "" || txtBox_descripcion.Text == "" || txtBox_nombre.Text == "" || txtBox_precio.Text == "" || cBox_categoria.SelectedIndex == -1 || cBox_marca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos");
                return true;
            }
            if(txtBox_descripcion.Text.Length > 150)
            {
                MessageBox.Show("La descripcion del articulo no puede superar los 150 caracteres, intente nuevamente.");
                return true;
            }
            if(!decimal.TryParse(txtBox_precio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número");
                return true;
            }
            return false;

        }

        private void txtBox_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar <48 || e.KeyChar > 57) && (e.KeyChar <65 || e.KeyChar > 90))
            {
                e.Handled = true;
            }
        }

        private void txtBox_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (ValidarCampos())
                {
                    return;
                }
                if (articulo == null)
                {
                    articulo = new Articulo();

                    articulo.codigo = txtBox_codigo.Text;
                    articulo.nombre = txtBox_nombre.Text;
                    articulo.descripcion = txtBox_descripcion.Text;
                    articulo.marca = ((Marca)cBox_marca.SelectedItem);
                    articulo.categoria = ((Categoria)cBox_categoria.SelectedItem);
                    articulo.precio = decimal.Parse(txtBox_precio.Text);
                    articulo.imagenurl = txtBox_UrlImagen.Text;

                    negocio.agregarArticulo(articulo);
                    MessageBox.Show("Articulo agregado correctamente");
                    this.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void cargarImagen()
        {
            try
            {
                if (txtBox_UrlImagen.Text != "")
                {
                    pictureBox1.Load(txtBox_UrlImagen.Text);
                }
                else
                {
                    pictureBox1.Load("https://www.thermaxglobal.com/wp-content/uploads/2020/05/image-not-found.jpg");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
