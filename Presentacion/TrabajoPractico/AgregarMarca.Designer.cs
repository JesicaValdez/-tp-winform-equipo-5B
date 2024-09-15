namespace TrabajoPractico
{
    partial class AgregarMarca
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
            this.btn_aceptarM = new System.Windows.Forms.Button();
            this.txt_agregarM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelarM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_aceptarM
            // 
            this.btn_aceptarM.Location = new System.Drawing.Point(41, 112);
            this.btn_aceptarM.Name = "btn_aceptarM";
            this.btn_aceptarM.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptarM.TabIndex = 0;
            this.btn_aceptarM.Text = "Aceptar";
            this.btn_aceptarM.UseVisualStyleBackColor = true;
            this.btn_aceptarM.Click += new System.EventHandler(this.btn_aceptarM_Click);
            // 
            // txt_agregarM
            // 
            this.txt_agregarM.Location = new System.Drawing.Point(41, 71);
            this.txt_agregarM.Name = "txt_agregarM";
            this.txt_agregarM.Size = new System.Drawing.Size(230, 20);
            this.txt_agregarM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregar marca";
            // 
            // btn_cancelarM
            // 
            this.btn_cancelarM.Location = new System.Drawing.Point(196, 112);
            this.btn_cancelarM.Name = "btn_cancelarM";
            this.btn_cancelarM.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelarM.TabIndex = 3;
            this.btn_cancelarM.Text = "Cancelar";
            this.btn_cancelarM.UseVisualStyleBackColor = true;
            this.btn_cancelarM.Click += new System.EventHandler(this.btn_cancelarM_Click);
            // 
            // AgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 185);
            this.Controls.Add(this.btn_cancelarM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_agregarM);
            this.Controls.Add(this.btn_aceptarM);
            this.Name = "AgregarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptarM;
        private System.Windows.Forms.TextBox txt_agregarM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelarM;
    }
}