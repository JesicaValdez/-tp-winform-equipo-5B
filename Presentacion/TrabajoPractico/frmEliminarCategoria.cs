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
    
    public partial class frmEliminarCategoria : Form
    {
        private List<Categoria> categoriasLista;
        public frmEliminarCategoria()
        {
            InitializeComponent();
        }

        private void frmEliminarCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                categoriasLista = negocio.ListarCategorias();
                dgv_eliminar.DataSource = categoriasLista;
                dgv_eliminar.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_eliminar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_eliminar.CurrentRow != null)
            {
                Categoria seleccionada = ((Categoria)dgv_eliminar.CurrentRow.DataBoundItem);
            }
            else
            {
                MessageBox.Show("No hay una fila seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_eliminarCat_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionada;
            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro desea elminar la categoria?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionada = ((Categoria)dgv_eliminar.CurrentRow.DataBoundItem);
                    negocio.eliminarCategoria(seleccionada);
                    MessageBox.Show("Categoria eliminada con exito");
                    categoriasLista = negocio.ListarCategorias();
                    dgv_eliminar.DataSource = categoriasLista;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelarEliminarCat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
