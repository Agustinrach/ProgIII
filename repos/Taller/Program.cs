using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10];
            int media = 0;
            double[] varianza = new double[10];
            double mediaVarianza = 0;
            double desviacionEstandar;
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("\nIngrese una estatura N°" + (i + 1) + ": ");
                arreglo[i] = int.Parse(Console.ReadLine());
                media += arreglo[i];
            }
            media = media / 10;

            for (i = 0; i < 10; i++)
            {
                varianza[i] = Math.Pow((arreglo[i] - media), 2);
                mediaVarianza += varianza[i];

            }
            mediaVarianza = mediaVarianza / 10;
            desviacionEstandar = Math.Sqrt(mediaVarianza);

            Console.WriteLine("\n\nLa estatura media es: " + media);
            Console.WriteLine("La desviación estándar es: " + desviacionEstandar);
            Console.WriteLine("\n\n");

            for (i = 0; i < 10; i++)
            {
                if (arreglo[i] > media)
                {
                    Console.WriteLine("Altura N°" + (i + 1) + " es MAYOR a la media");
                }
                else Console.WriteLine("Altura N°" + (i + 1) + " es MENOR a la media");

            }
            Console.ReadLine();

        }
    }
}
