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
    public partial class frmModificarCategoria : Form
    {
        private List<Categoria> listaCategorias;

        public frmModificarCategoria()
        {
            InitializeComponent();
        }

       
        private void frmModificarCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            listaCategorias = negocio.ListarCategorias();
            dgv_modificarCategoria.DataSource = listaCategorias;
            dgv_modificarCategoria.Columns["Id"].Visible = false;


        }

        private void dgv_modificarCategoria_SelectionChanged(object sender, EventArgs e)
        {
            
            if(dgv_modificarCategoria.CurrentRow == null)
            {
                MessageBox.Show("No hay una fila seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(dgv_modificarCategoria.CurrentRow != null)
            {
                Categoria categoria = (Categoria)dgv_modificarCategoria.CurrentRow.DataBoundItem;
                txt_modificarCategoria.Text = categoria.Descripcion;
            }

            

        }

        private void btn_aceptarModCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria categoria = new Categoria();
            categoria.Descripcion = txt_modificarCategoria.Text;
            categoria.Id = ((Categoria)dgv_modificarCategoria.CurrentRow.DataBoundItem).Id;
            negocio.modificaCategoria(categoria);
            listaCategorias = negocio.ListarCategorias();
            dgv_modificarCategoria.DataSource = listaCategorias;
            txt_modificarCategoria.Text = "";

            MessageBox.Show("Categoria modificada correctamente");
        }

        private void btn_cancelarModCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
