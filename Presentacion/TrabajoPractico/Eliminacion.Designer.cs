namespace TrabajoPractico
{
    partial class Eliminacion
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
            this.pbox_elimiar = new System.Windows.Forms.PictureBox();
            this.btn_atras = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_elimiar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_eliminar
            // 
            this.dgv_eliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_eliminar.Location = new System.Drawing.Point(13, 13);
            this.dgv_eliminar.Name = "dgv_eliminar";
            this.dgv_eliminar.Size = new System.Drawing.Size(477, 230);
            this.dgv_eliminar.TabIndex = 0;
            this.dgv_eliminar.SelectionChanged += new System.EventHandler(this.dgv_eliminar_SelectionChanged);
            // 
            // pbox_elimiar
            // 
            this.pbox_elimiar.Location = new System.Drawing.Point(497, 13);
            this.pbox_elimiar.Name = "pbox_elimiar";
            this.pbox_elimiar.Size = new System.Drawing.Size(219, 230);
            this.pbox_elimiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_elimiar.TabIndex = 1;
            this.pbox_elimiar.TabStop = false;
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(617, 249);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(98, 23);
            this.btn_atras.TabIndex = 2;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Eliminacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.pbox_elimiar);
            this.Controls.Add(this.dgv_eliminar);
            this.Name = "Eliminacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminacion";
            this.Load += new System.EventHandler(this.Eliminacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_elimiar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_eliminar;
        private System.Windows.Forms.PictureBox pbox_elimiar;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button button1;
    }
}