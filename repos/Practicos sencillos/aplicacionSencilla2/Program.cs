using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionSencilla2
{
    class Program
    {
        static void Main(string[] args)
        {
            //***************************************************************************************************************************************
            //Realice un programa que solicite cuál fue el primer día del mes, luego con esta información el sistema debe poder calcular que día será.
            Console.WriteLine("Año 2022\nDame el numero del mes y te digo el primer dia: ");
            int mes = int.Parse(Console.ReadLine());
            DateTime diaDelMes = new DateTime(2022, mes, 01);
            Console.WriteLine(diaDelMes.ToString("D"));

            //***************************************************************************************************************************************
            //dada una determinada fecha el mismo le indique que día será.
            //El sistema también podrá responder al requerimiento que fechas caen los fines de semana de un determinado mes.
            Console.WriteLine("\n\n");
            Console.WriteLine("Dame una fecha te digo el dia: ");
            DateTime fecha = new DateTime();
            fecha = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("el {0} fue el dia {1}", fecha.ToString("d"),fecha.ToString("dddd"));

            //***************************************************************************************************************************************
            //El sistema también podrá responder al requerimiento que fechas caen los fines de semana de un determinado mes.
            Console.WriteLine("\n\n");
            Console.WriteLine("Dame un mes y te digo sus findes: ");
            int mesFindes = int.Parse(Console.ReadLine());
            int diasMesFindes = DateTime.DaysInMonth(2022, mesFindes);

            for (int i = 1; i <= diasMesFindes; i++)
            {
                DateTime finde = new DateTime(2022, mesFindes, i);
                if (finde.ToString("dddd") == "sábado" || finde.ToString("dddd") == "domingo")
                {
                    Console.WriteLine("el {0} cae {1}", finde.ToString("d"), finde.ToString("dddd"));
                }


            }
            //*****************************************************************************************************************************************************************
            //Se espera que pueda arrojar el monto de un presupuesto para desarrollo considerando la siguiente información. La hora de desarrollo será de $3000, el programador
            //trabajará 4 horas por día en el proyecto. Él estimo terminar con la incidencia 10 días habiles, comenzando el 8 de abril de 2022.

            
            int cont = 0;
            
                for (int i = 0; i < 14; i++)
                {
                    DateTime comienzoProyecto = new DateTime(2022, 04, 08+i);
                    if (comienzoProyecto.ToString("dddd") != "sábado" && comienzoProyecto.ToString("dddd") != "domingo")
                    {
                        cont ++;
                    }
                }
            DateTime finalProyecto = new DateTime(2022, 04, 21);

            Console.WriteLine("\n\nEl programador terminará el proyecto el dia {0}", finalProyecto.ToString("d"));
            Console.WriteLine("Ganará $3000 por hora, trabajando 4 hs al día");
            Console.WriteLine("TOTAL: ${0}",3000*4*10);

            Console.ReadKey();
        }
    }
}
