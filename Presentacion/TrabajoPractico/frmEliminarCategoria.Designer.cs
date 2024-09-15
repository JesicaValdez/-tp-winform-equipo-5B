namespace TrabajoPractico
{
    partial class frmEliminarCategoria
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
            this.dgv_eliminar = new System.Windows.Forms.DataGridView();
            this.btn_eliminarCat = new System.Windows.Forms.Button();
            this.btn_cancelarEliminarCat = new System.Windows.Forms.Button();
            this.lb_EliminarCat = new System.Windows.Forms.Label();
            this.gpb_eliminarCat = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eliminar)).BeginInit();
            this.gpb_eliminarCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_eliminar
            // 
            this.dgv_eliminar.BackgroundColor = System.Drawing.Color.DarkMagenta;
            this.dgv_eliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_eliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_eliminar.GridColor = System.Drawing.Color.DarkMagenta;
            this.dgv_eliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_eliminar.Location = new System.Drawing.Point(68, 40);
            this.dgv_eliminar.Name = "dgv_eliminar";
            this.dgv_eliminar.Size = new System.Drawing.Size(169, 225);
            this.dgv_eliminar.TabIndex = 0;
            this.dgv_eliminar.SelectionChanged += new System.EventHandler(this.dgv_eliminar_SelectionChanged);
            // 
            // btn_eliminarCat
            // 
            this.btn_eliminarCat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_eliminarCat.Location = new System.Drawing.Point(117, 282);
            this.btn_eliminarCat.Name = "btn_eliminarCat";
            this.btn_eliminarCat.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminarCat.TabIndex = 1;
            this.btn_eliminarCat.Text = "Eliminar";
            this.btn_eliminarCat.UseVisualStyleBackColor = true;
            this.btn_eliminarCat.Click += new System.EventHandler(this.btn_eliminarCat_Click);
            // 
            // btn_cancelarEliminarCat
            // 
            this.btn_cancelarEliminarCat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cancelarEliminarCat.Location = new System.Drawing.Point(123, 405);
            this.btn_cancelarEliminarCat.Name = "btn_cancelarEliminarCat";
            this.btn_cancelarEliminarCat.Size = new System.Drawing.Size(123, 23);
            this.btn_cancelarEliminarCat.TabIndex = 2;
            this.btn_cancelarEliminarCat.Text = "Volver atras";
            this.btn_cancelarEliminarCat.UseVisualStyleBackColor = true;
            this.btn_cancelarEliminarCat.Click += new System.EventHandler(this.btn_cancelarEliminarCat_Click);
            // 
            // lb_EliminarCat
            // 
            this.lb_EliminarCat.AutoSize = true;
            this.lb_EliminarCat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EliminarCat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_EliminarCat.Location = new System.Drawing.Point(73, 0);
            this.lb_EliminarCat.Name = "lb_EliminarCat";
            this.lb_EliminarCat.Size = new System.Drawing.Size(155, 23);
            this.lb_EliminarCat.TabIndex = 3;
            this.lb_EliminarCat.Text = "Eliminar Categoria";
            // 
            // gpb_eliminarCat
            // 
            this.gpb_eliminarCat.BackColor = System.Drawing.Color.Thistle;
            this.gpb_eliminarCat.Controls.Add(this.dgv_eliminar);
            this.gpb_eliminarCat.Controls.Add(this.lb_EliminarCat);
            this.gpb_eliminarCat.Controls.Add(this.btn_eliminarCat);
            this.gpb_eliminarCat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gpb_eliminarCat.Location = new System.Drawing.Point(28, 55);
            this.gpb_eliminarCat.Name = "gpb_eliminarCat";
            this.gpb_eliminarCat.Size = new System.Drawing.Size(308, 334);
            this.gpb_eliminarCat.TabIndex = 4;
            this.gpb_eliminarCat.TabStop = false;
            // 
            // frmEliminarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.gpb_eliminarCat);
            this.Controls.Add(this.btn_cancelarEliminarCat);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEliminarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Categoria";
            this.Load += new System.EventHandler(this.frmEliminarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eliminar)).EndInit();
            this.gpb_eliminarCat.ResumeLayout(false);
            this.gpb_eliminarCat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_eliminarCat;
        private System.Windows.Forms.Button btn_cancelarEliminarCat;
        private System.Windows.Forms.Label lb_EliminarCat;
        private System.Windows.Forms.GroupBox gpb_eliminarCat;
        private System.Windows.Forms.DataGridView dgv_eliminar;
    }
}