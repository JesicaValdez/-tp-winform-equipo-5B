namespace TrabajoPractico
{
    partial class frmModificarArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_modificarArticulo = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pb_Modificado = new System.Windows.Forms.PictureBox();
            this.panel_NuevoArticulo = new System.Windows.Forms.Panel();
            this.lb_UrlImagen = new System.Windows.Forms.Label();
            this.txtBox_UrlImagen = new System.Windows.Forms.TextBox();
            this.txtBox_precio = new System.Windows.Forms.TextBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.cBox_categoria = new System.Windows.Forms.ComboBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.cBox_marca = new System.Windows.Forms.ComboBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.txtBox_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txtBox_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txtBox_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbArticuloNuevo = new System.Windows.Forms.Label();
            this.pb_actual = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modificarArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Modificado)).BeginInit();
            this.panel_NuevoArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_actual)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_modificarArticulo
            // 
            this.dgv_modificarArticulo.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_modificarArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modificarArticulo.Location = new System.Drawing.Point(75, 48);
            this.dgv_modificarArticulo.Name = "dgv_modificarArticulo";
            this.dgv_modificarArticulo.Size = new System.Drawing.Size(642, 221);
            this.dgv_modificarArticulo.TabIndex = 0;
            this.dgv_modificarArticulo.SelectionChanged += new System.EventHandler(this.dgv_modificarArticulo_SelectionChanged);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cancelar.Location = new System.Drawing.Point(439, 540);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "Salir";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAceptar.Location = new System.Drawing.Point(246, 540);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Modificar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pb_Modificado
            // 
            this.pb_Modificado.Location = new System.Drawing.Point(723, 275);
            this.pb_Modificado.Name = "pb_Modificado";
            this.pb_Modificado.Size = new System.Drawing.Size(247, 250);
            this.pb_Modificado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Modificado.TabIndex = 8;
            this.pb_Modificado.TabStop = false;
            // 
            // panel_NuevoArticulo
            // 
            this.panel_NuevoArticulo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_NuevoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_NuevoArticulo.Controls.Add(this.lb_UrlImagen);
            this.panel_NuevoArticulo.Controls.Add(this.txtBox_UrlImagen);
            this.panel_NuevoArticulo.Controls.Add(this.txtBox_precio);
            this.panel_NuevoArticulo.Controls.Add(this.lbl_precio);
            this.panel_NuevoArticulo.Controls.Add(this.cBox_categoria);
            this.panel_NuevoArticulo.Controls.Add(this.lbl_categoria);
            this.panel_NuevoArticulo.Controls.Add(this.cBox_marca);
            this.panel_NuevoArticulo.Controls.Add(this.lbl_marca);
            this.panel_NuevoArticulo.Controls.Add(this.txtBox_descripcion);
            this.panel_NuevoArticulo.Controls.Add(this.lbl_descripcion);
            this.panel_NuevoArticulo.Controls.Add(this.txtBox_nombre);
            this.panel_NuevoArticulo.Controls.Add(this.lbl_nombre);
            this.panel_NuevoArticulo.Controls.Add(this.txtBox_codigo);
            this.panel_NuevoArticulo.Controls.Add(this.lbl_codigo);
            this.panel_NuevoArticulo.Location = new System.Drawing.Point(75, 275);
            this.panel_NuevoArticulo.Name = "panel_NuevoArticulo";
            this.panel_NuevoArticulo.Size = new System.Drawing.Size(642, 250);
            this.panel_NuevoArticulo.TabIndex = 7;
            // 
            // lb_UrlImagen
            // 
            this.lb_UrlImagen.AutoSize = true;
            this.lb_UrlImagen.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UrlImagen.Location = new System.Drawing.Point(290, 134);
            this.lb_UrlImagen.Name = "lb_UrlImagen";
            this.lb_UrlImagen.Size = new System.Drawing.Size(71, 14);
            this.lb_UrlImagen.TabIndex = 13;
            this.lb_UrlImagen.Text = "URL Imagen";
            // 
            // txtBox_UrlImagen
            // 
            this.txtBox_UrlImagen.Location = new System.Drawing.Point(293, 154);
            this.txtBox_UrlImagen.Name = "txtBox_UrlImagen";
            this.txtBox_UrlImagen.Size = new System.Drawing.Size(234, 20);
            this.txtBox_UrlImagen.TabIndex = 12;
            // 
            // txtBox_precio
            // 
            this.txtBox_precio.Location = new System.Drawing.Point(293, 206);
            this.txtBox_precio.Name = "txtBox_precio";
            this.txtBox_precio.Size = new System.Drawing.Size(234, 20);
            this.txtBox_precio.TabIndex = 11;
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(290, 186);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(40, 14);
            this.lbl_precio.TabIndex = 10;
            this.lbl_precio.Text = "Precio";
            // 
            // cBox_categoria
            // 
            this.cBox_categoria.FormattingEnabled = true;
            this.cBox_categoria.Location = new System.Drawing.Point(293, 92);
            this.cBox_categoria.Name = "cBox_categoria";
            this.cBox_categoria.Size = new System.Drawing.Size(234, 21);
            this.cBox_categoria.TabIndex = 9;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(290, 72);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(59, 14);
            this.lbl_categoria.TabIndex = 8;
            this.lbl_categoria.Text = "Categoria";
            // 
            // cBox_marca
            // 
            this.cBox_marca.FormattingEnabled = true;
            this.cBox_marca.Location = new System.Drawing.Point(293, 36);
            this.cBox_marca.Name = "cBox_marca";
            this.cBox_marca.Size = new System.Drawing.Size(234, 21);
            this.cBox_marca.TabIndex = 7;
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca.Location = new System.Drawing.Point(290, 15);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(40, 14);
            this.lbl_marca.TabIndex = 6;
            this.lbl_marca.Text = "Marca";
            // 
            // txtBox_descripcion
            // 
            this.txtBox_descripcion.Location = new System.Drawing.Point(22, 154);
            this.txtBox_descripcion.Name = "txtBox_descripcion";
            this.txtBox_descripcion.Size = new System.Drawing.Size(234, 20);
            this.txtBox_descripcion.TabIndex = 5;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(19, 134);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(71, 14);
            this.lbl_descripcion.TabIndex = 4;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // txtBox_nombre
            // 
            this.txtBox_nombre.Location = new System.Drawing.Point(22, 92);
            this.txtBox_nombre.Name = "txtBox_nombre";
            this.txtBox_nombre.Size = new System.Drawing.Size(234, 20);
            this.txtBox_nombre.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(19, 72);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(115, 14);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre del articulo";
            // 
            // txtBox_codigo
            // 
            this.txtBox_codigo.Location = new System.Drawing.Point(22, 36);
            this.txtBox_codigo.Name = "txtBox_codigo";
            this.txtBox_codigo.Size = new System.Drawing.Size(234, 20);
            this.txtBox_codigo.TabIndex = 1;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(19, 15);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(105, 14);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Codigo de articulo";
            // 
            // lbArticuloNuevo
            // 
            this.lbArticuloNuevo.AutoSize = true;
            this.lbArticuloNuevo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArticuloNuevo.Location = new System.Drawing.Point(12, 12);
            this.lbArticuloNuevo.Name = "lbArticuloNuevo";
            this.lbArticuloNuevo.Size = new System.Drawing.Size(154, 23);
            this.lbArticuloNuevo.TabIndex = 6;
            this.lbArticuloNuevo.Text = "Modificar Articulo";
            // 
            // pb_actual
            // 
            this.pb_actual.Location = new System.Drawing.Point(723, 48);
            this.pb_actual.Name = "pb_actual";
            this.pb_actual.Size = new System.Drawing.Size(247, 221);
            this.pb_actual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_actual.TabIndex = 11;
            this.pb_actual.TabStop = false;
            // 
            // frmModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 566);
            this.Controls.Add(this.pb_actual);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pb_Modificado);
            this.Controls.Add(this.panel_NuevoArticulo);
            this.Controls.Add(this.lbArticuloNuevo);
            this.Controls.Add(this.dgv_modificarArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarArticulo";
            this.Text = "Modificar Articulo";
            this.Load += new System.EventHandler(this.frmModificarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modificarArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Modificado)).EndInit();
            this.panel_NuevoArticulo.ResumeLayout(false);
            this.panel_NuevoArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_actual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_modificarArticulo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pb_Modificado;
        private System.Windows.Forms.Panel panel_NuevoArticulo;
        private System.Windows.Forms.Label lb_UrlImagen;
        private System.Windows.Forms.TextBox txtBox_UrlImagen;
        private System.Windows.Forms.TextBox txtBox_precio;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.ComboBox cBox_categoria;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.ComboBox cBox_marca;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.TextBox txtBox_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txtBox_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txtBox_codigo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbArticuloNuevo;
        private System.Windows.Forms.PictureBox pb_actual;
    }
}