using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4
{
    public partial class Form1 : Form
    {
        Clase objClase = new Clase();
        string dirArchivo ="";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            objClase.AgregarAtributo(txtNombreAtrib.Text, cmbTipo.Text);
            lstAtributos.Items.Add(txtNombreAtrib.Text + "-" + cmbTipo.Text);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            objClase.Nombre = txtNombreClass.Text;
            rtbClase.Text = objClase.GenerarClase();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(lstAtributos.SelectedIndex != -1)
            {
                objClase.EliminarAtributos(lstAtributos.SelectedIndex);
                lstAtributos.Items.RemoveAt(lstAtributos.SelectedIndex);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dirArchivo != "")
            {
                StreamWriter escribir = new StreamWriter(dirArchivo);
                escribir.WriteLine(rtbClase.Text);
                escribir.Close();
            }
            else
            {

                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Title = "Guardar Archivos";
                guardar.Filter = "Clase de C#(*.cs)|*.cs";
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    dirArchivo = guardar.FileName;
                    StreamWriter escribir = File.AppendText(dirArchivo);
                    escribir.WriteLine(rtbClase.Text);
                    escribir.Close();
                }
            }
        }
    }
}
