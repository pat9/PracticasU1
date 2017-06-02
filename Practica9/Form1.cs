using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica9
{
    public partial class frmPrac9 : Form
    {
        MatrizMagica objMatriz = new MatrizMagica();
        public frmPrac9()
        {
            InitializeComponent();
        }

        private void Comprobar_Click(object sender, EventArgs e)
        {
            objMatriz.Matriz[0, 0] = int.Parse(txtN1.Text);
            objMatriz.Matriz[0, 1] = int.Parse(txtN2.Text);
            objMatriz.Matriz[0, 2] = int.Parse(txtN3.Text);

            objMatriz.Matriz[1, 0] = int.Parse(txtN4.Text);
            objMatriz.Matriz[1, 1] = int.Parse(txtN5.Text);
            objMatriz.Matriz[1, 2] = int.Parse(txtN6.Text);

            objMatriz.Matriz[2, 0] = int.Parse(txtN7.Text);
            objMatriz.Matriz[2, 1] = int.Parse(txtN8.Text);
            objMatriz.Matriz[2, 2] = int.Parse(txtN9.Text);

            objMatriz.HacerSuma();

            if(objMatriz.ComprobarMatriz() == 1)
            {
                MessageBox.Show("Es magico");
                lblSuma.Text = "La suma es: " + objMatriz.suma;
            }
            else
            {
                MessageBox.Show("NO es magico");
                lblSuma.Text = "";
            }
        }
    }
}
