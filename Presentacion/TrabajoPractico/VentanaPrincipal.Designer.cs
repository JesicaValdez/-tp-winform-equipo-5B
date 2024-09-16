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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
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
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.StatusStrip();
            this.statusLb = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.statusLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Articulo,
            this.buscarToolStripMenuItem,
            this.tsm_Marca,
            this.tsm_Categoria});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1088, 24);
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
            this.articulosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("articulosToolStripMenuItem.Image")));
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.articulosToolStripMenuItem.Text = "Listar";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripMenuItem.Image")));
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.agregarToolStripMenuItem.Text = "Agregar Artículo";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem.Image")));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.modificarToolStripMenuItem.Text = "Modificar Artículo";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // tsm_detalle
            // 
            this.tsm_detalle.Image = ((System.Drawing.Image)(resources.GetObject("tsm_detalle.Image")));
            this.tsm_detalle.Name = "tsm_detalle";
            this.tsm_detalle.Size = new System.Drawing.Size(170, 22);
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
            this.porMarcaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("porMarcaToolStripMenuItem.Image")));
            this.porMarcaToolStripMenuItem.Name = "porMarcaToolStripMenuItem";
            this.porMarcaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.porMarcaToolStripMenuItem.Text = "por Marca";
            this.porMarcaToolStripMenuItem.Click += new System.EventHandler(this.porMarcaToolStripMenuItem_Click);
            // 
            // porCategoriaToolStripMenuItem
            // 
            this.porCategoriaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("porCategoriaToolStripMenuItem.Image")));
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
            this.AgregarMarca.Image = ((System.Drawing.Image)(resources.GetObject("AgregarMarca.Image")));
            this.AgregarMarca.Name = "AgregarMarca";
            this.AgregarMarca.Size = new System.Drawing.Size(125, 22);
            this.AgregarMarca.Text = "Agregar";
            this.AgregarMarca.Click += new System.EventHandler(this.AgregarMarca_Click);
            // 
            // tsm_modificarMarca
            // 
            this.tsm_modificarMarca.Image = ((System.Drawing.Image)(resources.GetObject("tsm_modificarMarca.Image")));
            this.tsm_modificarMarca.Name = "tsm_modificarMarca";
            this.tsm_modificarMarca.Size = new System.Drawing.Size(125, 22);
            this.tsm_modificarMarca.Text = "Modificar";
            this.tsm_modificarMarca.Click += new System.EventHandler(this.tsm_modificarMarca_Click);
            // 
            // tsm_eliminarMarca
            // 
            this.tsm_eliminarMarca.Image = ((System.Drawing.Image)(resources.GetObject("tsm_eliminarMarca.Image")));
            this.tsm_eliminarMarca.Name = "tsm_eliminarMarca";
            this.tsm_eliminarMarca.Size = new System.Drawing.Size(125, 22);
            this.tsm_eliminarMarca.Text = "Eliminar";
            this.tsm_eliminarMarca.Click += new System.EventHandler(this.tsm_eliminarMarca_Click);
            // 
            // tsm_listarMarca
            // 
            this.tsm_listarMarca.Image = ((System.Drawing.Image)(resources.GetObject("tsm_listarMarca.Image")));
            this.tsm_listarMarca.Name = "tsm_listarMarca";
            this.tsm_listarMarca.Size = new System.Drawing.Size(125, 22);
            this.tsm_listarMarca.Text = "Listar";
            this.tsm_listarMarca.Click += new System.EventHandler(this.tsm_listarMarca_Click);
            // 
            // tsm_Categoria
            // 
            this.tsm_Categoria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_agregarCategoria,
            this.tsm_modificarCategoria,
            this.tsm_eliminarCategoria,
            this.tsm_listarCategoria});
            this.tsm_Categoria.Name = "tsm_Categoria";
            this.tsm_Categoria.Size = new System.Drawing.Size(75, 20);
            this.tsm_Categoria.Text = "Categorías";
            // 
            // tsm_agregarCategoria
            // 
            this.tsm_agregarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("tsm_agregarCategoria.Image")));
            this.tsm_agregarCategoria.Name = "tsm_agregarCategoria";
            this.tsm_agregarCategoria.Size = new System.Drawing.Size(179, 22);
            this.tsm_agregarCategoria.Text = "Agregar Categoría";
            this.tsm_agregarCategoria.Click += new System.EventHandler(this.tsm_agregarCategoria_Click);
            // 
            // tsm_modificarCategoria
            // 
            this.tsm_modificarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("tsm_modificarCategoria.Image")));
            this.tsm_modificarCategoria.Name = "tsm_modificarCategoria";
            this.tsm_modificarCategoria.Size = new System.Drawing.Size(179, 22);
            this.tsm_modificarCategoria.Text = "Modificar Categoría";
            this.tsm_modificarCategoria.Click += new System.EventHandler(this.tsm_modificarCategoria_Click);
            // 
            // tsm_eliminarCategoria
            // 
            this.tsm_eliminarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("tsm_eliminarCategoria.Image")));
            this.tsm_eliminarCategoria.Name = "tsm_eliminarCategoria";
            this.tsm_eliminarCategoria.Size = new System.Drawing.Size(179, 22);
            this.tsm_eliminarCategoria.Text = "Eliminar";
            this.tsm_eliminarCategoria.Click += new System.EventHandler(this.tsm_eliminarCategoria_Click);
            // 
            // tsm_listarCategoria
            // 
            this.tsm_listarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("tsm_listarCategoria.Image")));
            this.tsm_listarCategoria.Name = "tsm_listarCategoria";
            this.tsm_listarCategoria.Size = new System.Drawing.Size(179, 22);
            this.tsm_listarCategoria.Text = "Listar";
            this.tsm_listarCategoria.Click += new System.EventHandler(this.tsm_listarCategoria_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.label1);
            this.pnlContenido.Controls.Add(this.button1);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 24);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1088, 453);
            this.pnlContenido.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido al Sistema de Gestión";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(963, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLb});
            this.statusLabel.Location = new System.Drawing.Point(0, 455);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(1088, 22);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "statusStrip1";
            // 
            // statusLb
            // 
            this.statusLb.Name = "statusLb";
            this.statusLb.Size = new System.Drawing.Size(73, 17);
            this.statusLb.Text = "Estado: Listo";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 477);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de gestion de Articulos";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.statusLabel.ResumeLayout(false);
            this.statusLabel.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgv_articulos;
        private System.Windows.Forms.PictureBox pbx_articulo;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.StatusStrip statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusLb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

