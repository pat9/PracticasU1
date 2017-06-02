namespace Practica9
{
    partial class frmPrac9
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN6 = new System.Windows.Forms.TextBox();
            this.txtN5 = new System.Windows.Forms.TextBox();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.txtN9 = new System.Windows.Forms.TextBox();
            this.txtN8 = new System.Windows.Forms.TextBox();
            this.txtN7 = new System.Windows.Forms.TextBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.Comprobar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(51, 57);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(46, 20);
            this.txtN1.TabIndex = 0;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(103, 57);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(46, 20);
            this.txtN2.TabIndex = 1;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(155, 57);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(46, 20);
            this.txtN3.TabIndex = 2;
            // 
            // txtN6
            // 
            this.txtN6.Location = new System.Drawing.Point(155, 83);
            this.txtN6.Name = "txtN6";
            this.txtN6.Size = new System.Drawing.Size(46, 20);
            this.txtN6.TabIndex = 5;
            // 
            // txtN5
            // 
            this.txtN5.Location = new System.Drawing.Point(103, 83);
            this.txtN5.Name = "txtN5";
            this.txtN5.Size = new System.Drawing.Size(46, 20);
            this.txtN5.TabIndex = 4;
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(51, 83);
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(46, 20);
            this.txtN4.TabIndex = 3;
            // 
            // txtN9
            // 
            this.txtN9.Location = new System.Drawing.Point(155, 109);
            this.txtN9.Name = "txtN9";
            this.txtN9.Size = new System.Drawing.Size(46, 20);
            this.txtN9.TabIndex = 8;
            // 
            // txtN8
            // 
            this.txtN8.Location = new System.Drawing.Point(103, 109);
            this.txtN8.Name = "txtN8";
            this.txtN8.Size = new System.Drawing.Size(46, 20);
            this.txtN8.TabIndex = 7;
            // 
            // txtN7
            // 
            this.txtN7.Location = new System.Drawing.Point(51, 109);
            this.txtN7.Name = "txtN7";
            this.txtN7.Size = new System.Drawing.Size(46, 20);
            this.txtN7.TabIndex = 6;
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(48, 197);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(34, 13);
            this.lblSuma.TabIndex = 9;
            this.lblSuma.Text = "Suma";
            // 
            // Comprobar
            // 
            this.Comprobar.Location = new System.Drawing.Point(51, 146);
            this.Comprobar.Name = "Comprobar";
            this.Comprobar.Size = new System.Drawing.Size(150, 23);
            this.Comprobar.TabIndex = 10;
            this.Comprobar.Text = "Comprobar";
            this.Comprobar.UseVisualStyleBackColor = true;
            this.Comprobar.Click += new System.EventHandler(this.Comprobar_Click);
            // 
            // frmPrac9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 261);
            this.Controls.Add(this.Comprobar);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.txtN9);
            this.Controls.Add(this.txtN8);
            this.Controls.Add(this.txtN7);
            this.Controls.Add(this.txtN6);
            this.Controls.Add(this.txtN5);
            this.Controls.Add(this.txtN4);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Name = "frmPrac9";
            this.Text = "Cuadro Magico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtN6;
        private System.Windows.Forms.TextBox txtN5;
        private System.Windows.Forms.TextBox txtN4;
        private System.Windows.Forms.TextBox txtN9;
        private System.Windows.Forms.TextBox txtN8;
        private System.Windows.Forms.TextBox txtN7;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Button Comprobar;
    }
}

