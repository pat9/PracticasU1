using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Practica2
{
    class BlocNotas
    {
 

        public BlocNotas()
        {

        }

        //Mi metodo es de tipo RichTextBox porque quiero manipularlo le paso como parametro la fuente del usuario y
        //el RichTextBox del form
        public RichTextBox CambiarFuente(Font fuente, RichTextBox texto)
        {
            //Cambio la fuente del RichTextBox y lo retorno
            texto.Font = fuente;
            return texto;
        }

        //Lo mismo es aqui solo que con color
        public RichTextBox CambiarColor(Color color, RichTextBox texto)
        {
            texto.ForeColor = color;
            return texto;
        }
    }
}
