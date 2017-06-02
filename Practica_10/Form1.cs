using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] arreglo = { -2, 5, 8, -9, 10, 15, -4 };
            int sumaNegat= 0;
            int sumaPosit = 0;
            foreach(var numero in arreglo)
            {
                if(numero<0)
                {
                    sumaNegat = sumaNegat + numero;
                }
                else
                {
                    sumaPosit = sumaPosit + numero;
                }
            }

            lblNegativos.Text = "La suma de los negativos es: " + sumaNegat;
            lblPositivos.Text = "La suma de los positivos es: " + sumaPosit;
        }
    }
}
