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

        private void CargarFormularios(Form formulario)
        {
            pnlContenido.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlContenido.Controls.Add(formulario);
            pnlContenido.Tag = formulario;
            formulario.Show();
        }

        private void mostrarPantallaBienvenida()
        {
            pnlContenido.Controls.Clear();

            label1.Text = "Bienvenido al sistema de gestión de articulos";
            label1.Font = new Font("Arial", 20, FontStyle.Bold);
            
            Label lb_instrucciones = new Label();
            lb_instrucciones.Text = "Seleccione una opción del menú para comenzar";
        }
        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            
            statusLb.Text = "Estado: Listo";

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
            CargarFormularios(ventanaArticulo);
        }

        private void tsm_agregarCategoria_Click(object sender, EventArgs e)
        {
            frm_AgregarCategoria ventanaCategoria = new frm_AgregarCategoria();
            CargarFormularios(ventanaCategoria);
        }

        private void tsm_modificarCategoria_Click(object sender, EventArgs e)
        {
            frmModificarCategoria ventanaModificarCategoria = new frmModificarCategoria();
            CargarFormularios(ventanaModificarCategoria);
        }

        private void tsm_eliminarCategoria_Click(object sender, EventArgs e)
        {
            frmEliminarCategoria ventanaEliminarCategoria = new frmEliminarCategoria();
            CargarFormularios(ventanaEliminarCategoria);
        }

        private void tsm_listarCategoria_Click(object sender, EventArgs e)
        {
            frmListarCategoria ventanaListarCategoria = new frmListarCategoria();
            CargarFormularios(ventanaListarCategoria);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarArticulo ventanaModificarArticulo = new frmModificarArticulo();
            CargarFormularios(ventanaModificarArticulo);
        }

        private void AgregarMarca_Click(object sender, EventArgs e)
        {
            AgregarMarca ventana = new AgregarMarca();
            ventana.ShowDialog();
        }

        private void tsm_eliminarMarca_Click(object sender, EventArgs e)
        {
            EliminarMarca ventana = new EliminarMarca();
            ventana.ShowDialog();
        }

        private void tsm_modificarMarca_Click(object sender, EventArgs e)
        {
            ModificarMarca ventana = new ModificarMarca();
            ventana.ShowDialog();
        }

        private void tsm_listarMarca_Click(object sender, EventArgs e)
        {
            ListarMarca ventana = new ListarMarca();
            ventana.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
