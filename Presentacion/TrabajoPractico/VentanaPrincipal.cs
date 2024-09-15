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
    public partial class VentanaPrincipal : Form
    {
        private System.Windows.Forms.ToolStripMenuItem tsm_detalle;

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaArticulos ventana2 = new frmListaArticulos();
            ventana2.ShowDialog();
        }



        private void porMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarporMarca ventana3 = new frmBuscarporMarca();
            ventana3.ShowDialog();
        }

        private void porCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarporCategoria ventana4 = new frmBuscarporCategoria();
            ventana4.ShowDialog();
        }

        private void tsm_detalle_Click(object sender, EventArgs e)
        {
           DetalleArticulo ventana = new DetalleArticulo();
           ventana.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminacion ventana = new Eliminacion();
            ventana.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarArticulo ventanaArticulo = new AgregarArticulo();
            ventanaArticulo.ShowDialog();
        }

        private void tsm_agregarCategoria_Click(object sender, EventArgs e)
        {
            frm_AgregarCategoria ventanaCategoria = new frm_AgregarCategoria();
            ventanaCategoria.ShowDialog();
        }

        private void tsm_modificarCategoria_Click(object sender, EventArgs e)
        {
            frmModificarCategoria ventanaModificarCategoria = new frmModificarCategoria();
            ventanaModificarCategoria.ShowDialog();
        }

        private void AgregarMarca_Click(object sender, EventArgs e)
        {
            AgregarMarca ventana = new AgregarMarca();
            ventana.ShowDialog();
        }

        private void tsm_listarMarca_Click(object sender, EventArgs e)
        {
            ListarMarca ventana = new ListarMarca();
            ventana.ShowDialog();
        }
    }
}
