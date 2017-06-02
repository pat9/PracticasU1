namespace Practica_10
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPositivos = new System.Windows.Forms.Label();
            this.lblNegativos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPositivos
            // 
            this.lblPositivos.AutoSize = true;
            this.lblPositivos.Location = new System.Drawing.Point(36, 69);
            this.lblPositivos.Name = "lblPositivos";
            this.lblPositivos.Size = new System.Drawing.Size(49, 13);
            this.lblPositivos.TabIndex = 0;
            this.lblPositivos.Text = "Positivos";
            // 
            // lblNegativos
            // 
            this.lblNegativos.AutoSize = true;
            this.lblNegativos.Location = new System.Drawing.Point(36, 99);
            this.lblNegativos.Name = "lblNegativos";
            this.lblNegativos.Size = new System.Drawing.Size(55, 13);
            this.lblNegativos.TabIndex = 1;
            this.lblNegativos.Text = "Negativos";
            this.lblNegativos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblNegativos);
            this.Controls.Add(this.lblPositivos);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPositivos;
        private System.Windows.Forms.Label lblNegativos;
    }
}

