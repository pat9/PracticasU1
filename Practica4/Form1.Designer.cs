namespace Practica4
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
            this.rtbClase = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreClass = new System.Windows.Forms.TextBox();
            this.Atributos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreAtrib = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lstAtributos = new System.Windows.Forms.ListBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbClase
            // 
            this.rtbClase.Location = new System.Drawing.Point(12, 190);
            this.rtbClase.Name = "rtbClase";
            this.rtbClase.Size = new System.Drawing.Size(595, 292);
            this.rtbClase.TabIndex = 0;
            this.rtbClase.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la clase: ";
            // 
            // txtNombreClass
            // 
            this.txtNombreClass.Location = new System.Drawing.Point(149, 31);
            this.txtNombreClass.Name = "txtNombreClass";
            this.txtNombreClass.Size = new System.Drawing.Size(163, 20);
            this.txtNombreClass.TabIndex = 2;
            // 
            // Atributos
            // 
            this.Atributos.AutoSize = true;
            this.Atributos.Location = new System.Drawing.Point(41, 59);
            this.Atributos.Name = "Atributos";
            this.Atributos.Size = new System.Drawing.Size(48, 13);
            this.Atributos.TabIndex = 3;
            this.Atributos.Text = "Atributos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo: ";
            // 
            // txtNombreAtrib
            // 
            this.txtNombreAtrib.Location = new System.Drawing.Point(98, 82);
            this.txtNombreAtrib.Name = "txtNombreAtrib";
            this.txtNombreAtrib.Size = new System.Drawing.Size(121, 20);
            this.txtNombreAtrib.TabIndex = 6;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "int",
            "double",
            "float",
            "string",
            "bool"});
            this.cmbTipo.Location = new System.Drawing.Point(98, 109);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 7;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(44, 136);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(175, 23);
            this.btn_Agregar.TabIndex = 8;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lstAtributos
            // 
            this.lstAtributos.FormattingEnabled = true;
            this.lstAtributos.Location = new System.Drawing.Point(248, 64);
            this.lstAtributos.Name = "lstAtributos";
            this.lstAtributos.Size = new System.Drawing.Size(171, 95);
            this.lstAtributos.TabIndex = 9;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(432, 64);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(175, 23);
            this.btnGenerar.TabIndex = 10;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(44, 161);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(432, 93);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(175, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 542);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lstAtributos);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtNombreAtrib);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Atributos);
            this.Controls.Add(this.txtNombreClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbClase);
            this.Name = "Form1";
            this.Text = "Practica 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbClase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreClass;
        private System.Windows.Forms.Label Atributos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreAtrib;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.ListBox lstAtributos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
    }
}

