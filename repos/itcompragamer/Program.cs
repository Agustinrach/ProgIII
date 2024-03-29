using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itcompragamer
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] myArray = { 1, 2, 1, 3, 3, 1, 2, 1, 5, 1 };
            int cont1 = 0;
            int cont2 = 0;
            int cont3 = 0;
            int cont4 = 0;
            int cont5 = 0;

            for (int i =0; i < 10; i++)
            {
                if (myArray[i] == 1)
                {
                    cont1++;
                }
                if (myArray[i] == 2)
                {
                    cont2++;
                }
                if (myArray[i] == 3)
                {
                    cont3++;
                }
                if (myArray[i] == 4)
                {
                    cont4++;
                }
                if (myArray[i] == 5)
                {
                    cont5++;
                }
                
            }

            int[] unos = new int[cont1];
            int[] dos = new int[cont2];
            int[] tres = new int[cont3];
            int[] cuatros = new int[cont4];
            int[] cincos = new int[cont5];

             
        }
    }
}
