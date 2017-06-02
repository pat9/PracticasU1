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

namespace Practica2
{
    public partial class frmPract2 : Form
    {
        BlocNotas objNotas = new BlocNotas();
        string dirArchivo;
        public frmPract2()
        {
            InitializeComponent();
        }

        private void fuenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*Para cambiar la fuente primero es crear un font dialog*/
            FontDialog fuente = new FontDialog();
            //Luego hay que verificar de que el usuario haya elegido un color
            if (fuente.ShowDialog() == DialogResult.OK)
            {
                /*Si eligio alguno mandamos a llamar al metodo que esta en la clase
                 * le paso dos parametros uno es la fuente que se elijio y otro es el RichTextBox completo
                 */
                this.rbtTexto = objNotas.CambiarFuente(fuente.Font, this.rbtTexto);
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lo unico que cambia aqui es que en lugar de Font Dialog es Color y que en lugar de mandar una fuente
            // Mando un color
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                this.rbtTexto = objNotas.CambiarColor(color.Color, this.rbtTexto);
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbtTexto.Clear();
            rbtTexto.Focus();
            dirArchivo = "";
            rbtTexto.Enabled = true;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Abrir archivos";
            abrir.Filter = "formato de texto enriquecido(*.rtf)|*.rtf";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                abrir.OpenFile();
                dirArchivo = abrir.FileName;

                StreamReader lector = File.OpenText(dirArchivo);

                rbtTexto.Text = lector.ReadToEnd();

                guardarComoToolStripMenuItem.Enabled = true;
                guardarToolStripMenuItem.Enabled = true;
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dirArchivo != "")
            {
                StreamWriter escribir = new StreamWriter(dirArchivo);
                escribir.WriteLine(rbtTexto.Text);
                escribir.Close();
            }
            else
            {

                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Title = "Guardar Archivos";
                guardar.Filter = "formato de texto enriquecido(*.rtf)|*.rtf";
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    dirArchivo = guardar.FileName;
                    StreamWriter escribir = File.AppendText(dirArchivo);
                    escribir.WriteLine(rbtTexto.Text);
                    escribir.Close();
                }
            }

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Title = "Guardar Archivos";
            guardar.Filter = "formato de texto enriquecido(*.rtf)|*.rtf";
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                dirArchivo = guardar.FileName;
                StreamWriter escribir = File.AppendText(dirArchivo);
                escribir.WriteLine(rbtTexto.Text);
                escribir.Close();
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbtTexto.Clear();
            dirArchivo = "";

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmPract2_Load(object sender, EventArgs e)
        {

        }
    }
}