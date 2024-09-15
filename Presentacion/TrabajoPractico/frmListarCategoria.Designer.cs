namespace TrabajoPractico
{
    partial class frmListarCategoria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ListCat = new System.Windows.Forms.DataGridView();
            this.btn_ListarCategorias = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListCat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Thistle;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgv_ListCat);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(35, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgv_ListCat
            // 
            this.dgv_ListCat.BackgroundColor = System.Drawing.Color.DarkMagenta;
            this.dgv_ListCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListCat.Location = new System.Drawing.Point(67, 51);
            this.dgv_ListCat.Name = "dgv_ListCat";
            this.dgv_ListCat.Size = new System.Drawing.Size(148, 230);
            this.dgv_ListCat.TabIndex = 0;
            // 
            // btn_ListarCategorias
            // 
            this.btn_ListarCategorias.Location = new System.Drawing.Point(153, 414);
            this.btn_ListarCategorias.Name = "btn_ListarCategorias";
            this.btn_ListarCategorias.Size = new System.Drawing.Size(75, 23);
            this.btn_ListarCategorias.TabIndex = 1;
            this.btn_ListarCategorias.Text = "Volver Atras";
            this.btn_ListarCategorias.UseVisualStyleBackColor = true;
            this.btn_ListarCategorias.Click += new System.EventHandler(this.btn_ListarCategorias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(54, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de Categorias";
            // 
            // frmListarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.btn_ListarCategorias);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmListarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Categoria";
            this.Load += new System.EventHandler(this.frmListarCategoria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_ListCat;
        private System.Windows.Forms.Button btn_ListarCategorias;
        private System.Windows.Forms.Label label1;
    }
}