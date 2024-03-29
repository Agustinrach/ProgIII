using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasRepetitivas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] alturas = new int[10];

            List<int> mayores = new List<int>();
            List<int> menores = new List<int>();
            List<int> listaDentroRango = new List<int>();


            double media = 0;
            double varianza = 0;
            double desvio = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese la altura {i + 1}:");
                int.TryParse(Console.ReadLine(), out alturas[i]);

                media += alturas[i];

            }


            media /= 10;



            foreach (int medida in alturas)
            {
                if (medida >= media)
                {
                    mayores.Add(medida);
                }
                else if (medida < media)
                {
                    menores.Add(medida);
                }

            }


            Console.WriteLine($"\nMedia = {media}");

            Console.Write("Alturas mayores que la media: {");
            foreach (int num in mayores)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("}");
            Console.Write("Alturas menores que la media: {");

            foreach (int num in menores)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("}");

            //desvio estandar
            //primero saco la varianza


            for (int i = 0; i < 10; i++)
            {
                double rango = 0;
                rango = Math.Pow(alturas[i] - media, 2);
                varianza += rango;
            }

            varianza = varianza / 10;
            //desvio es la raiz de la varianza
            desvio = Math.Sqrt(varianza);

            Console.WriteLine($"Desvio estandar {desvio}");



            double extremoMenor = media - desvio;
            double extremoMayor = media + desvio;

            Console.WriteLine("\nRango definido por la desviacion estandar: [{0:N2} - {1:N2}] ",extremoMenor,extremoMayor);

            //cargo lista con las alturas que se encuentran dentro del rango definido por la desviación estándar.
            for (int i = 0; i < 10; i++)
            {
                if (alturas[i] <= (media + desvio) && alturas[i] >= (media - desvio))
                {
                    //
                    listaDentroRango.Add(alturas[i]);

                }

            }
            Console.Write("\n\nAlturas que se encuentran dentro del rango definido por la desviación estándar: {");
      
            foreach (int pos in listaDentroRango)
            {
                Console.Write($"{pos} ");
             }
             Console.Write("}");


            Console.ReadKey();


        }
    }
}
