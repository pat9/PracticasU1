using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6
{
    class MaquinaCambio
    {
        public double monto { get; set; }
        public double pago { get; set; }
        public double cambio { get; set; }
        private int[] billetes { get; set; }
        private int[] monedas { get; set; }

        public MaquinaCambio()
        {
            this.monedas = new int[10];
            this.billetes = new int[5];
            this.monto = 0;
            this.cambio = 0;
        }

        public double CalcularCambio()
        {
            cambio = monto - pago;
            return cambio;
        }

        public int[] CambioMonedas()
        {
            double cambio = this.cambio;
            while (cambio > 0)
            {
                if (cambio >= 50)
                {
                    monedas[0]++;
                    cambio = cambio - 50;
                }
                else if (cambio >= 20)
                {
                    monedas[1]++;
                    cambio = cambio - 20;
                }
                else if (cambio >= 10)
                {
                    monedas[2]++;
                    cambio = cambio - 10;
                }
                else if (cambio >= 5)
                {
                    monedas[3]++;
                    cambio = cambio - 5;
                }
                else if (cambio >= 2)
                {
                    monedas[4]++;
                    cambio = cambio - 2;
                }
                else if (cambio >= 1)
                {
                    monedas[5]++;
                    cambio = cambio - 1;
                }
                else if(cambio >= .50)
                {
                    monedas[6]++;
                    cambio = cambio - .50;
                }
                else if(cambio>=.20)
                {
                    monedas[7]++;
                    cambio = cambio - .20;
                }
                else if(cambio>=.10)
                {
                    monedas[8]++;
                    cambio = cambio - .10;
                }
                else if(cambio>=.05)
                {
                    monedas[9]++;
                    cambio = cambio - .05;
                }
            }
            this.cambio = cambio;
            return monedas;
        }

        public int[] CambioBilletes(double cambio)
        {
            cambio = this.cambio;
            if(cambio >= 500)
            {
                billetes[0]++;
                cambio = cambio - 500;
            }
            else if(cambio >=200)
            {
                billetes[1]++;
                cambio = cambio - 500;
            }
            else if(cambio>=100)
            {
                billetes[3]++;
                cambio = cambio - 500;
            }
            else if(cambio>=50)
            {
                billetes[4]++;
                cambio = cambio - 500;
            }

            return billetes;
        }

        public void CambioConBilletes()
        {
            CambioBilletes(this.cambio);
            CambioMonedas();
        }
        
    }
}
