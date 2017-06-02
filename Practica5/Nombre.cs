using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    class Nombre
    {

        public string NombreCompleto { get; set; }
        private string[] NombreAlreves;
        private string[] NombreVertical;
        private string[] Letras;
        private int[] Numero;
        private string Resultado;
        public Nombre(string nombre)
        {
            NombreCompleto = nombre.ToUpper();
            Resultado = "";
            NombreAlreves = new string[NombreCompleto.Length];
            Letras = new string[NombreCompleto.Length];
            Numero = new int[NombreCompleto.Length];
            NombreVertical = new string[NombreCompleto.Length];
        }

        public void VoltearNombre()
        {
            int cont = 0;
            for (int i = NombreCompleto.Length - 1; i >= 0; i--)
            {
                NombreAlreves[cont] = NombreCompleto[i].ToString();
                cont++;
            }

        }

        public void PonerVertical()
        {
            int cont = 0;
            for (int i = NombreCompleto.Length - 1; i >= 0; i--)
            {
                NombreVertical[cont] = NombreCompleto[i].ToString() + "\n";
                cont++;
            }
        }

        public void Contar()
        {
            Letras[0] = NombreCompleto[0].ToString();
            Numero[0] = 1;
            for(int i=1; i<NombreCompleto.Length; i++)
            {
                string letra = NombreCompleto[i].ToString();
                for (int j = i; j < NombreCompleto.Length; j++)
                {
                    if(NombreCompleto[j].ToString() != letra)
                    {
                        Letras[i] = letra.ToString();
                        Numero[i] = 1;
                    }
                    else
                    {
                        Numero[j]++;
                    }
                }


            }
        }



        public string Mostrar()
        {
            for (int i = 0; i < NombreAlreves.Length; i++)
            {
                Resultado = Resultado + NombreAlreves[i];
            }

            Resultado = Resultado + "\n\n";

            for (int i = 0; i < NombreVertical.Length; i++)
            {
                Resultado = Resultado + NombreVertical[i];
            }

            Resultado = Resultado + "\n\n";



            return Resultado;
        }


    }
}
