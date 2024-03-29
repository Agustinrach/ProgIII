using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha1 = new DateTime(2022, 5, 4);
            DateTime fecha2 = new DateTime(2022, 5, 10);
            Periodo periodo1 = new Periodo(fecha1, fecha2);
            Periodo periodo2 = new Periodo(new DateTime(2022, 5, 6), new DateTime(2022, 5, 12));
            Periodo periodo3 = new Periodo(new DateTime(2022,5,7), new DateTime(2022,5,9));

            Periodo[] arrayPeriodos = new Periodo[] { periodo1, periodo2, periodo3 };


            unirPeriodos(arrayPeriodos);

            void unirPeriodos( Periodo[] arrayPeriodo)
            {
                DateTime inicio = arrayPeriodo[0].propInicio;
                DateTime final = arrayPeriodo[0].propFinal;

                for (int i = 1; i < arrayPeriodo.Length; i++)
                {
                    if (arrayPeriodo[i].propInicio < inicio)
                    {
                        inicio = arrayPeriodo[i].propInicio;
                    }
                    if (arrayPeriodo[i].propFinal > final)
                    {
                        final = arrayPeriodo[i].propFinal;
                    }
                }
                Periodo resultado = new Periodo(inicio, final);
                Console.WriteLine("EL PERIODO RESULTADO ES : {0} al {1}", inicio.ToString("d"), final.ToString("d"));
            }


            Console.ReadKey();

        }
    }

}