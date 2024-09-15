namespace TrabajoPractico
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_Articulo = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_detalle = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Marca = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_modificarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_eliminarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_listarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Categoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_agregarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_modificarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_eliminarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_listarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Imagen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Articulo,
            this.buscarToolStripMenuItem,
            this.tsm_Marca,
            this.tsm_Categoria,
            this.tsm_Imagen});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_Articulo
            // 
            this.tsmi_Articulo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.tsm_detalle});
            this.tsmi_Articulo.Name = "tsmi_Articulo";
            this.tsmi_Articulo.Size = new System.Drawing.Size(61, 20);
            this.tsmi_Articulo.Text = "Articulo";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // tsm_detalle
            // 
            this.tsm_detalle.Name = "tsm_detalle";
            this.tsm_detalle.Size = new System.Drawing.Size(180, 22);
            this.tsm_detalle.Text = "Ver detalle";
            this.tsm_detalle.Click += new System.EventHandler(this.tsm_detalle_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porMarcaToolStripMenuItem,
            this.porCategoriaToolStripMenuItem});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // porMarcaToolStripMenuItem
            // 
            this.porMarcaToolStripMenuItem.Name = "porMarcaToolStripMenuItem";
            this.porMarcaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.porMarcaToolStripMenuItem.Text = "por Marca";
            this.porMarcaToolStripMenuItem.Click += new System.EventHandler(this.porMarcaToolStripMenuItem_Click);
            // 
            // porCategoriaToolStripMenuItem
            // 
            this.porCategoriaToolStripMenuItem.Name = "porCategoriaToolStripMenuItem";
            this.porCategoriaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.porCategoriaToolStripMenuItem.Text = "por Categoria";
            this.porCategoriaToolStripMenuItem.Click += new System.EventHandler(this.porCategoriaToolStripMenuItem_Click);
            // 
            // tsm_Marca
            // 
            this.tsm_Marca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarMarca,
            this.tsm_modificarMarca,
            this.tsm_eliminarMarca,
            this.tsm_listarMarca});
            this.tsm_Marca.Name = "tsm_Marca";
            this.tsm_Marca.Size = new System.Drawing.Size(52, 20);
            this.tsm_Marca.Text = "Marca";
            // 
            // AgregarMarca
            // 
            this.AgregarMarca.Name = "AgregarMarca";
            this.AgregarMarca.Size = new System.Drawing.Size(125, 22);
            this.AgregarMarca.Text = "Agregar";
            // 
            // tsm_modificarMarca
            // 
            this.tsm_modificarMarca.Name = "tsm_modificarMarca";
            this.tsm_modificarMarca.Size = new System.Drawing.Size(125, 22);
            this.tsm_modificarMarca.Text = "Modificar";
            // 
            // tsm_eliminarMarca
            // 
            this.tsm_eliminarMarca.Name = "tsm_eliminarMarca";
            this.tsm_eliminarMarca.Size = new System.Drawing.Size(125, 22);
            this.tsm_eliminarMarca.Text = "Eliminar";
            // 
            // tsm_listarMarca
            // 
            this.tsm_listarMarca.Name = "tsm_listarMarca";
            this.tsm_listarMarca.Size = new System.Drawing.Size(125, 22);
            this.tsm_listarMarca.Text = "Listar";
            // 
            // tsm_Categoria
            // 
            this.tsm_Categoria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_agregarCategoria,
            this.tsm_modificarCategoria,
            this.tsm_eliminarCategoria,
            this.tsm_listarCategoria});
            this.tsm_Categoria.Name = "tsm_Categoria";
            this.tsm_Categoria.Size = new System.Drawing.Size(70, 20);
            this.tsm_Categoria.Text = "Categoria";
            // 
            // tsm_agregarCategoria
            // 
            this.tsm_agregarCategoria.Name = "tsm_agregarCategoria";
            this.tsm_agregarCategoria.Size = new System.Drawing.Size(180, 22);
            this.tsm_agregarCategoria.Text = "Agregar";
            this.tsm_agregarCategoria.Click += new System.EventHandler(this.tsm_agregarCategoria_Click);
            // 
            // tsm_modificarCategoria
            // 
            this.tsm_modificarCategoria.Name = "tsm_modificarCategoria";
            this.tsm_modificarCategoria.Size = new System.Drawing.Size(180, 22);
            this.tsm_modificarCategoria.Text = "Modificar";
            this.tsm_modificarCategoria.Click += new System.EventHandler(this.tsm_modificarCategoria_Click);
            // 
            // tsm_eliminarCategoria
            // 
            this.tsm_eliminarCategoria.Name = "tsm_eliminarCategoria";
            this.tsm_eliminarCategoria.Size = new System.Drawing.Size(125, 22);
            this.tsm_eliminarCategoria.Text = "Eliminar";
            // 
            // tsm_listarCategoria
            // 
            this.tsm_listarCategoria.Name = "tsm_listarCategoria";
            this.tsm_listarCategoria.Size = new System.Drawing.Size(125, 22);
            this.tsm_listarCategoria.Text = "Listar";
            // 
            // tsm_Imagen
            // 
            this.tsm_Imagen.Name = "tsm_Imagen";
            this.tsm_Imagen.Size = new System.Drawing.Size(59, 20);
            this.tsm_Imagen.Text = "Imagen";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 293);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de gestion de Articulos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Articulo;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_Marca;
        private System.Windows.Forms.ToolStripMenuItem AgregarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsm_modificarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsm_eliminarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsm_listarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsm_Categoria;
        private System.Windows.Forms.ToolStripMenuItem tsm_agregarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsm_modificarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsm_eliminarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsm_listarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsm_Imagen;
        private System.Windows.Forms.DataGridView dgv_articulos;
        private System.Windows.Forms.PictureBox pbx_articulo;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_siguiente;
    }
}

