namespace TrabajoPractico
{
    partial class frm_AgregarCategoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelNewCat = new System.Windows.Forms.Panel();
            this.lbCatNueva = new System.Windows.Forms.Label();
            this.dgv_categoriaAgregada = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.panelNewCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categoriaAgregada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Categoria";
            // 
            // panelNewCat
            // 
            this.panelNewCat.BackColor = System.Drawing.Color.Thistle;
            this.panelNewCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNewCat.Controls.Add(this.lbCatNueva);
            this.panelNewCat.Controls.Add(this.label1);
            this.panelNewCat.Controls.Add(this.dgv_categoriaAgregada);
            this.panelNewCat.Controls.Add(this.btn_cancelar);
            this.panelNewCat.Controls.Add(this.btn_aceptar);
            this.panelNewCat.Controls.Add(this.txt_categoria);
            this.panelNewCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewCat.Location = new System.Drawing.Point(0, 0);
            this.panelNewCat.Name = "panelNewCat";
            this.panelNewCat.Size = new System.Drawing.Size(464, 450);
            this.panelNewCat.TabIndex = 6;
            // 
            // lbCatNueva
            // 
            this.lbCatNueva.AutoSize = true;
            this.lbCatNueva.Location = new System.Drawing.Point(97, 114);
            this.lbCatNueva.Name = "lbCatNueva";
            this.lbCatNueva.Size = new System.Drawing.Size(63, 13);
            this.lbCatNueva.TabIndex = 5;
            this.lbCatNueva.Text = "Descripcion";
            // 
            // dgv_categoriaAgregada
            // 
            this.dgv_categoriaAgregada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categoriaAgregada.Location = new System.Drawing.Point(97, 174);
            this.dgv_categoriaAgregada.Name = "dgv_categoriaAgregada";
            this.dgv_categoriaAgregada.Size = new System.Drawing.Size(243, 127);
            this.dgv_categoriaAgregada.TabIndex = 4;
            this.dgv_categoriaAgregada.SelectionChanged += new System.EventHandler(this.dgv_categoriaAgregada_SelectionChanged);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(250, 334);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(100, 334);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.Text = "Agregar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(97, 133);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(243, 20);
            this.txt_categoria.TabIndex = 1;
            // 
            // frm_AgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.panelNewCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frm_AgregarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Categoria";
            this.Load += new System.EventHandler(this.frm_AgregarCategoria_Load);
            this.panelNewCat.ResumeLayout(false);
            this.panelNewCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categoriaAgregada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelNewCat;
        private System.Windows.Forms.Label lbCatNueva;
        private System.Windows.Forms.DataGridView dgv_categoriaAgregada;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txt_categoria;
    }
}