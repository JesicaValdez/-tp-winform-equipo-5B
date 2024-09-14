namespace TrabajoPractico
{
    partial class DetalleArticulo
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
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.pbox_oculta = new System.Windows.Forms.PictureBox();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_detalleItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_oculta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_list
            // 
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(13, 13);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.Size = new System.Drawing.Size(143, 225);
            this.dgv_list.TabIndex = 0;
            this.dgv_list.SelectionChanged += new System.EventHandler(this.dgv_list_SelectionChanged);
            // 
            // pbox_oculta
            // 
            this.pbox_oculta.Location = new System.Drawing.Point(214, 115);
            this.pbox_oculta.Name = "pbox_oculta";
            this.pbox_oculta.Size = new System.Drawing.Size(32, 28);
            this.pbox_oculta.TabIndex = 1;
            this.pbox_oculta.TabStop = false;
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(185, 176);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(88, 42);
            this.btn_atras.TabIndex = 2;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_detalleItem
            // 
            this.btn_detalleItem.Location = new System.Drawing.Point(185, 40);
            this.btn_detalleItem.Name = "btn_detalleItem";
            this.btn_detalleItem.Size = new System.Drawing.Size(88, 42);
            this.btn_detalleItem.TabIndex = 3;
            this.btn_detalleItem.Text = "Ver detalle";
            this.btn_detalleItem.UseVisualStyleBackColor = true;
            this.btn_detalleItem.Click += new System.EventHandler(this.btn_detalleItem_Click);
            // 
            // DetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 274);
            this.Controls.Add(this.btn_detalleItem);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.pbox_oculta);
            this.Controls.Add(this.dgv_list);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetalleArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleArticulo";
            this.Load += new System.EventHandler(this.DetalleArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_oculta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.PictureBox pbox_oculta;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_detalleItem;
    }
}