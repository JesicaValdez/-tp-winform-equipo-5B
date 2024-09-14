namespace TrabajoPractico
{
    partial class frmBuscarporCategoria
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
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.dgvBuscarCat = new System.Windows.Forms.DataGridView();
            this.pbxCat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda por Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria: ";
            // 
            // cboCat
            // 
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(102, 94);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(151, 21);
            this.cboCat.TabIndex = 2;
            this.cboCat.SelectedValueChanged += new System.EventHandler(this.cboCat_SelectedValueChanged);
            // 
            // dgvBuscarCat
            // 
            this.dgvBuscarCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarCat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBuscarCat.Location = new System.Drawing.Point(19, 132);
            this.dgvBuscarCat.Name = "dgvBuscarCat";
            this.dgvBuscarCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarCat.Size = new System.Drawing.Size(590, 192);
            this.dgvBuscarCat.TabIndex = 3;
            this.dgvBuscarCat.SelectionChanged += new System.EventHandler(this.dgvBuscarCat_SelectionChanged);
            // 
            // pbxCat
            // 
            this.pbxCat.Location = new System.Drawing.Point(639, 134);
            this.pbxCat.Name = "pbxCat";
            this.pbxCat.Size = new System.Drawing.Size(209, 189);
            this.pbxCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCat.TabIndex = 4;
            this.pbxCat.TabStop = false;
            // 
            // frmBuscarporCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.pbxCat);
            this.Controls.Add(this.dgvBuscarCat);
            this.Controls.Add(this.cboCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscarporCategoria";
            this.Text = "frmBuscarporCategoria";
            this.Load += new System.EventHandler(this.frmBuscarporCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.DataGridView dgvBuscarCat;
        private System.Windows.Forms.PictureBox pbxCat;
    }
}