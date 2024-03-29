using System;

namespace EstructuraRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            const int cantidadPersona = 10;
            int[] arregloAlturas = new int[cantidadPersona];
            int alturaxEncima = 0, alturaxDebajo = 0;
            double media = 0, total = 0;
            double varianza = 0, desviacion = 0;
            int fueraderango = 0, dentroderango = 0;

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///Ingresamos las alturas al arreglo
            for (int i = 0; i < cantidadPersona; i++)
            {
                Console.WriteLine("Ingrese altura de la persona " + (i + 1) + " en cm: ");
                arregloAlturas[i] = int.Parse(Console.ReadLine());
                total += arregloAlturas[i];

            }
            Console.Clear();
            Console.WriteLine("Alturas Ingresadas: ");
            for (int i = 0; i < arregloAlturas.Length; i++)
            {

                Console.WriteLine("Altura de la persona " + (i + 1) + ":  " + arregloAlturas[i] + " cm");
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///Calculamos la media
            media = total / cantidadPersona;
            Console.WriteLine("\nMedia: " + media);

            for (int i = 0; i < arregloAlturas.Length; i++)
            {
                if (arregloAlturas[i] > media)
                {
                    alturaxEncima++;
                }
                if (arregloAlturas[i] < media)
                {
                    alturaxDebajo++;
                }
            }

            int[] arregloEM = new int[alturaxEncima];
            int[] arregloDM = new int[alturaxDebajo];

            int j = 0;
            int k = 0;
            //Cargamos el arreglo con las alturas que se encuentran por encima de la media y por debajo de ella
            for (int i = 0; i < arregloAlturas.Length; i++)
            {
                if (arregloAlturas[i] > media)
                {
                    arregloEM[j] = arregloAlturas[i];
                    j++;
                }
                if (arregloAlturas[i] < media)
                {
                    arregloDM[k] = arregloAlturas[i];
                    k++;
                }

            }

            //mostramos los datos del arreglo
            Console.WriteLine("\nAlturas por encima de la media: (" + alturaxEncima + ")");
            for (int i = 0; i < j; i++)
            {
                Console.Write(arregloEM[i] + "cm - ");
            }

            Console.WriteLine("\n\nAlturas por debajo de la media: (" + alturaxDebajo + ")");
            for (int i = 0; i < k; i++)
            {
                Console.Write(arregloDM[i] + "cm - ");
            }


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///DESVIACION ESTANDAR

            //Calculamos la varianza
            for (int i = 0; i < arregloAlturas.Length; i++)
            {
                double rango = 0;
                rango = Math.Pow(media - arregloAlturas[i], 2);
                varianza += rango;
            }
            varianza = varianza / cantidadPersona;
            //Calculamos la Desviacion Estandar
            desviacion = Math.Sqrt(varianza);
            Console.Write("\n\nDesviacion Estandar: {0:N2}", desviacion);

            for (int i = 0; i < arregloAlturas.Length; i++)
            {
                if (arregloAlturas[i] <= (media + desviacion) && arregloAlturas[i] >= (media - desviacion))
                {
                    dentroderango++;
                }

            }

            Console.Write("\nCantidad de alturas dentro del rango definido por la desviacion estandar: " + dentroderango);

            int[] arregloRango = new int[dentroderango];
            int l = 0;

            //cargando el arreglo con las alturas se encuentran dentro del rango definido por la desviación estándar.
            for (int i = 0; i < arregloAlturas.Length; i++)
            {
                if (arregloAlturas[i] <= (media + desviacion) && arregloAlturas[i] >= (media - desviacion))
                {
                    //
                    arregloRango[l] = arregloAlturas[i];
                    l++;
                }

            }
            Console.WriteLine("\n\nAlturas que se encuentran dentro del rango definido por la desviación estándar (" + dentroderango + ") :");
            //mostramos los datos del arreglo
            for (int i = 0; i < dentroderango; i++)
            {
                Console.Write(arregloRango[i] + " cm - ");
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.ReadKey();

        }
    }
}
