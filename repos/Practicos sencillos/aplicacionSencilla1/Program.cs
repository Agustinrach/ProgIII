using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionSencilla1
{
    class Program
    {
        static void Main(string[] args)
        {   //*****************************************************************************************************************************
            //Realice un programa en c# que muestre los numeros del cero al 100 utilizando las siguientes estructuras while, do- while,for.
            int i = 0, j = 0;
            Console.Write("mostrados con un while");
            while (i<= 100){
                Console.Write(", "+i);

                i++;
            }
            Console.WriteLine("\n");
            Console.Write("mostrados con un do-while");
            do
            {
                Console.Write(", " + j);
                j++;
            } while (j <= 100);

            Console.WriteLine("\n");
            Console.Write("mostrados con un for");

            for (int l = 0; l <=100 ; l++)
            {
                Console.Write(", " + l);
               
            }

            //*******************************************************************************************************************************************************
            //Realice un programa que solicite al usuario el ingreso de un número y que le muestre los diez primeros valores de la tabla de multiplicar de ese número
            
            Console.WriteLine("\n\nIngrese un numero y le doy su tabla: ");
            int num = int.Parse(Console.ReadLine());

            for (int k = 0; k <= 10; k++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, k, num * k);
            }


            Console.ReadKey();
        }
    }
}
