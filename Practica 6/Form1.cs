using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    public partial class Form1 : Form
    {
        MaquinaCambio objCambio = new MaquinaCambio();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objCambio.cambio = 555.55;
            //objCambio.CalcularCambio();
            objCambio.CambioMonedas();
        }
    }
}
