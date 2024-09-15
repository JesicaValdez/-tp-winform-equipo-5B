namespace TrabajoPractico
{
    partial class ListarMarca
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
            this.dgv_listarM = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_atrasM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarM)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listar marca";
            // 
            // dgv_listarM
            // 
            this.dgv_listarM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listarM.Location = new System.Drawing.Point(19, 20);
            this.dgv_listarM.Name = "dgv_listarM";
            this.dgv_listarM.Size = new System.Drawing.Size(240, 235);
            this.dgv_listarM.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_atrasM);
            this.panel1.Controls.Add(this.dgv_listarM);
            this.panel1.Location = new System.Drawing.Point(10, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 299);
            this.panel1.TabIndex = 2;
            // 
            // btn_atrasM
            // 
            this.btn_atrasM.Location = new System.Drawing.Point(106, 261);
            this.btn_atrasM.Name = "btn_atrasM";
            this.btn_atrasM.Size = new System.Drawing.Size(75, 23);
            this.btn_atrasM.TabIndex = 2;
            this.btn_atrasM.Text = "Atras";
            this.btn_atrasM.UseVisualStyleBackColor = true;
            this.btn_atrasM.Click += new System.EventHandler(this.btn_atrasM_Click);
            // 
            // ListarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 357);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ListarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarMarca";
            this.Load += new System.EventHandler(this.ListarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_listarM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_atrasM;
    }
}