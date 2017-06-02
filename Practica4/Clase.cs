using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practica4
{
    class Clase
    {
        public string Nombre { set; get; }
        private ArrayList atributos { set; get; }
        private ArrayList tipo { set; get; }

        private string ClaseConstruida;

        public Clase()
        {
            Nombre = "";
            atributos = new ArrayList();
            tipo = new ArrayList();
        }

        public string GenerarClase()
        {

            string cabecera =
                    "using System;\n" +
                    "using System.Collections.Generic;\n" +
                    "using System.Linq;\n" +
                    "using System.Text;\n" +
                    "using System.Threading.Tasks;\n\n" +
                    "public class " + Nombre + "\n\n"+
                    "{\n"+
                    "\n"+
                    "\t public " + Nombre + "()\n"+
                    "\t{\n\n"+
                    "\t}\n\n";


            string atributos = GenerarAtributos();

            ClaseConstruida = cabecera + atributos + "\n\n}";

            return ClaseConstruida;
        }

        private string GenerarAtributos()
        {
            string AtributosListos="";

            for (int i = 0; i < atributos.Count; i++)
            {
                AtributosListos =  AtributosListos+ "\t" + tipo[i] + " " + atributos[i] + ";\n";
            }

            return AtributosListos;
        }

        public void AgregarAtributo(string nombre, string tipo)
        {
            this.atributos.Add(nombre);
            this.tipo.Add(tipo);
        }

        public void EliminarAtributos(int index)
        {
            atributos.RemoveAt(index);
        }
    }
}
