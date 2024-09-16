namespace TrabajoPractico
{
    partial class frmModificarCategoria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCatNueva = new System.Windows.Forms.Label();
            this.lb_modificarCategoria = new System.Windows.Forms.Label();
            this.dgv_modificarCategoria = new System.Windows.Forms.DataGridView();
            this.btn_cancelarModCategoria = new System.Windows.Forms.Button();
            this.btn_aceptarModCategoria = new System.Windows.Forms.Button();
            this.txt_modificarCategoria = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modificarCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbCatNueva);
            this.panel1.Controls.Add(this.lb_modificarCategoria);
            this.panel1.Controls.Add(this.dgv_modificarCategoria);
            this.panel1.Controls.Add(this.btn_cancelarModCategoria);
            this.panel1.Controls.Add(this.btn_aceptarModCategoria);
            this.panel1.Controls.Add(this.txt_modificarCategoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 443);
            this.panel1.TabIndex = 8;
            // 
            // lbCatNueva
            // 
            this.lbCatNueva.AutoSize = true;
            this.lbCatNueva.Location = new System.Drawing.Point(88, 106);
            this.lbCatNueva.Name = "lbCatNueva";
            this.lbCatNueva.Size = new System.Drawing.Size(63, 13);
            this.lbCatNueva.TabIndex = 5;
            this.lbCatNueva.Text = "Descripcion";
            // 
            // lb_modificarCategoria
            // 
            this.lb_modificarCategoria.AutoSize = true;
            this.lb_modificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_modificarCategoria.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_modificarCategoria.Location = new System.Drawing.Point(12, 10);
            this.lb_modificarCategoria.Name = "lb_modificarCategoria";
            this.lb_modificarCategoria.Size = new System.Drawing.Size(200, 23);
            this.lb_modificarCategoria.TabIndex = 7;
            this.lb_modificarCategoria.Text = "MODIFICAR CATEGORIA";
            // 
            // dgv_modificarCategoria
            // 
            this.dgv_modificarCategoria.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_modificarCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modificarCategoria.Location = new System.Drawing.Point(115, 162);
            this.dgv_modificarCategoria.Name = "dgv_modificarCategoria";
            this.dgv_modificarCategoria.Size = new System.Drawing.Size(187, 200);
            this.dgv_modificarCategoria.TabIndex = 4;
            this.dgv_modificarCategoria.SelectionChanged += new System.EventHandler(this.dgv_modificarCategoria_SelectionChanged);
            // 
            // btn_cancelarModCategoria
            // 
            this.btn_cancelarModCategoria.Location = new System.Drawing.Point(227, 380);
            this.btn_cancelarModCategoria.Name = "btn_cancelarModCategoria";
            this.btn_cancelarModCategoria.Size = new System.Drawing.Size(75, 26);
            this.btn_cancelarModCategoria.TabIndex = 3;
            this.btn_cancelarModCategoria.Text = "Cancelar";
            this.btn_cancelarModCategoria.UseVisualStyleBackColor = true;
            this.btn_cancelarModCategoria.Click += new System.EventHandler(this.btn_cancelarModCategoria_Click);
            // 
            // btn_aceptarModCategoria
            // 
            this.btn_aceptarModCategoria.Location = new System.Drawing.Point(115, 380);
            this.btn_aceptarModCategoria.Name = "btn_aceptarModCategoria";
            this.btn_aceptarModCategoria.Size = new System.Drawing.Size(75, 26);
            this.btn_aceptarModCategoria.TabIndex = 2;
            this.btn_aceptarModCategoria.Text = "Aceptar";
            this.btn_aceptarModCategoria.UseVisualStyleBackColor = true;
            this.btn_aceptarModCategoria.Click += new System.EventHandler(this.btn_aceptarModCategoria_Click);
            // 
            // txt_modificarCategoria
            // 
            this.txt_modificarCategoria.Location = new System.Drawing.Point(88, 125);
            this.txt_modificarCategoria.Name = "txt_modificarCategoria";
            this.txt_modificarCategoria.Size = new System.Drawing.Size(263, 20);
            this.txt_modificarCategoria.TabIndex = 1;
            // 
            // frmModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 443);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmModificarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Categoria";
            this.Load += new System.EventHandler(this.frmModificarCategoria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modificarCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCatNueva;
        private System.Windows.Forms.DataGridView dgv_modificarCategoria;
        private System.Windows.Forms.Button btn_cancelarModCategoria;
        private System.Windows.Forms.Button btn_aceptarModCategoria;
        private System.Windows.Forms.TextBox txt_modificarCategoria;
        private System.Windows.Forms.Label lb_modificarCategoria;
    }
}