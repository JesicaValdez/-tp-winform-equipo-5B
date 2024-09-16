namespace TrabajoPractico
{
    partial class frmBuscarporMarca
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.dgvBuscarMarca = new System.Windows.Forms.DataGridView();
            this.pbxMarca = new System.Windows.Forms.PictureBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda por Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca: ";
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(88, 95);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(144, 21);
            this.cboMarca.TabIndex = 2;
            this.cboMarca.SelectedValueChanged += new System.EventHandler(this.cboMarca_SelectedValueChanged);
            // 
            // dgvBuscarMarca
            // 
            this.dgvBuscarMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarMarca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBuscarMarca.Location = new System.Drawing.Point(19, 134);
            this.dgvBuscarMarca.Name = "dgvBuscarMarca";
            this.dgvBuscarMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarMarca.Size = new System.Drawing.Size(611, 236);
            this.dgvBuscarMarca.TabIndex = 3;
            this.dgvBuscarMarca.SelectionChanged += new System.EventHandler(this.dgvBuscarMarca_SelectionChanged);
            // 
            // pbxMarca
            // 
            this.pbxMarca.Location = new System.Drawing.Point(661, 135);
            this.pbxMarca.Name = "pbxMarca";
            this.pbxMarca.Size = new System.Drawing.Size(211, 203);
            this.pbxMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMarca.TabIndex = 4;
            this.pbxMarca.TabStop = false;
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(19, 376);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(84, 20);
            this.botonVolver.TabIndex = 5;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.Location = new System.Drawing.Point(782, 349);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(89, 21);
            this.botonSiguiente.TabIndex = 6;
            this.botonSiguiente.Text = "Siguiente";
            this.botonSiguiente.UseVisualStyleBackColor = true;
            this.botonSiguiente.Click += new System.EventHandler(this.botonSiguiente_Click);
            // 
            // frmBuscarporMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 408);
            this.Controls.Add(this.botonSiguiente);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.pbxMarca);
            this.Controls.Add(this.dgvBuscarMarca);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarporMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscarporMarca";
            this.Load += new System.EventHandler(this.frmBuscarporMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.DataGridView dgvBuscarMarca;
        private System.Windows.Forms.PictureBox pbxMarca;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonSiguiente;
    }
}