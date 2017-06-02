using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica9
{
    class MatrizMagica
    {
        public int[,] Matriz { get; set; }
        public int suma { get; set; }

        public MatrizMagica()
        {
            Matriz = new int[3, 3];
        }

        public void HacerSuma()
        {
            suma = Matriz[0, 0] + Matriz[0, 1] + Matriz[0, 2];
        }

        public int ComprobarMatriz()
        {
            int[] sumas = new int[7];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 1 && (j == 0 || j == 1 || j == 2))
                    {
                        //1,0
                        sumas[0] = sumas[0] + Matriz[i, j];
                        //0,1
                        sumas[1] = sumas[1] + Matriz[j, i];
                    }
                    else if (i == 2 && (j == 0 || j == 1 || j == 2))
                    {
                        sumas[2] = sumas[2] + Matriz[i, j];
                        sumas[3] = sumas[3] + Matriz[j, i];
                    }
                    else if (i == 0 && (j == 0 || j == 1 || j == 2))
                    {
                        sumas[4] = sumas[4] + Matriz[j, i];
                    }
                    else if (i == j)
                    {
                        sumas[5] = sumas[5] + Matriz[j, i];
                    }
                    else if (i + j == 2)
                    {
                        sumas[6] = sumas[6] + Matriz[j, i];
                    }
                }

            }
            for (int o = 0; o < 7; o++)
            {
                if (suma != sumas[o])
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

            return 0;
        }         
   }
}
