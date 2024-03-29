using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    class ManejoFechas
    {

       public void obtenerDiasCalendario()
        {
            Console.WriteLine("Dame una fecha: ");
            DateTime fecha1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Dame otra fecha: ");
            DateTime fecha2 = DateTime.Parse(Console.ReadLine());
            TimeSpan resultado = fecha1 - fecha2;
            Console.WriteLine("Hay {0} dias entre las dos fechas", Math.Abs(resultado.Days));
           
        }

        public void UnirFechas(DateTime [] fechas)
        {

        }
        

        }





 }

