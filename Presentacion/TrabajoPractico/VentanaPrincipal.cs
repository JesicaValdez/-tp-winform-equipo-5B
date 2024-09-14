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
    public partial class VentanaPrincipal : Form
    {
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
    }
}
