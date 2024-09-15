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
    public partial class frm_AgregarCategoria : Form
    {
        private List<Categoria> listaCategorias;
        public frm_AgregarCategoria()
        {
            InitializeComponent();
        }

        private void frm_AgregarCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            listaCategorias = negocio.ListarCategorias();
            dgv_categoriaAgregada.DataSource = listaCategorias;
            dgv_categoriaAgregada.Columns["Id"].Visible = false;

        }

        private void dgv_categoriaAgregada_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_categoriaAgregada.CurrentRow != null)
            {
                Categoria categoriaSeleccionada = (Categoria)dgv_categoriaAgregada.CurrentRow.DataBoundItem;
                //statusLb.Text = "Categoria seleccionada: " + categoriaSeleccionada.Descripcion;
            }
            else
            {
                //statusLb.Text = "No hay una categoria seleccionada.";
            }
            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria categoria = new Categoria();

            categoria.Descripcion = txt_categoria.Text;

            bool categoriaExiste = listaCategorias.Any(c => c.Descripcion.Equals(categoria.Descripcion));

            if (categoriaExiste)
            {
                MessageBox.Show("La categoría ingresada ya existe. Por favor, ingrese una categoría diferente.", "Categoría existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                
                negocio.agregarCategoria(categoria);
                listaCategorias = negocio.ListarCategorias();
                dgv_categoriaAgregada.DataSource = listaCategorias;
                txt_categoria.Text = "";

                MessageBox.Show("Categoria agregada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
