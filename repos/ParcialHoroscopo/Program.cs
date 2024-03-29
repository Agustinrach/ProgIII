using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialHoroscopo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese su fecha de nacimiento con el siguiente formato: dd/mm/aaaa");
            DateTime fecha_nacimiento = DateTime.Parse(Console.ReadLine());

            if ((fecha_nacimiento.Day>= 23 && fecha_nacimiento.Month == 03) || fecha_nacimiento.Day >= 20 && fecha_nacimiento.Month == 04)
            {
                Console.WriteLine("Tu signo es ARIES");
                Console.WriteLine("Amor:  \nDinero: \n Bienestar: ");
            }
            if ((fecha_nacimiento.Day >= 21 && fecha_nacimiento.Month == 04) || fecha_nacimiento.Day >= 21 && fecha_nacimiento.Month == 05)
            {
                Console.WriteLine("Tu signo es TAURO");
                Console.WriteLine("Amor: \nDinero: \n Bienestar: ");
            }
            if ((fecha_nacimiento.Day >= 22 && fecha_nacimiento.Month == 05) || fecha_nacimiento.Day >= 21 && fecha_nacimiento.Month == 06)
            {
                Console.WriteLine("Tu signo es GEMINIS");
                Console.WriteLine("Amor: \nDinero: \n Bienestar: ");
            }
            if ((fecha_nacimiento.Day >= 22 && fecha_nacimiento.Month == 06) || fecha_nacimiento.Day >= 23 && fecha_nacimiento.Month == 07)
            {
                Console.WriteLine("Tu signo es CANCER");
                Console.WriteLine("Amor: \nDinero: \n Bienestar: ");
            }
            if ((fecha_nacimiento.Day >= 24 && fecha_nacimiento.Month == 07) || fecha_nacimiento.Day >= 23 && fecha_nacimiento.Month == 08)
            {
                Console.WriteLine("Tu signo es LEO");
                Console.WriteLine("Amor: \nDinero: \n Bienestar: ");
            }
            if ((fecha_nacimiento.Day >= 24 && fecha_nacimiento.Month == 08) || fecha_nacimiento.Day >= 23 && fecha_nacimiento.Month == 09)
            {
                Console.WriteLine("Tu signo es VIRGO");
                Console.WriteLine("Amor: \nDinero: \n Bienestar: ");
            }
            if ((fecha_nacimiento.Day >= 24 && fecha_nacimiento.Month == 09) || fecha_nacimiento.Day >= 20 && fecha_nacimiento.Month == 10)
            {
                Console.WriteLine("Tu signo es LIBRA");
                Console.WriteLine("Amor: \nDinero: \n Bienestar: ");
            }
            if ((fecha_nacimiento.Day >= 24 && fecha_nacimiento.Month == 10) || fecha_nacimiento.Day >= 22 && fecha_nacimiento.Month == 11)
            {
                Console.WriteLine("Tu signo es ESCORPIO");
                Console.WriteLine("Amor: \nDinero: \n Bienestar: ");
            }
            if ((fecha_nacimiento.Day >= 23 && fecha_nacimiento.Month == 11) || fecha_nacimiento.Day >= 22 && fecha_nacimiento.Month == 12)
            {
                Console.WriteLine("Tu signo es SAGITARIO");
                Console.WriteLine("Amor: \nDinero: \n Bienestar: ");
            }
            if ((fecha_nacimiento.Day >= 23 && fecha_nacimiento.Month == 12) || fecha_nacimiento.Day >= 20 && fecha_nacimiento.Month == 01)
            {
                Console.WriteLine("Tu signo es CAPRICORNIO");
                Console.WriteLine("Amor: \nDinero: \n Bienestar: ");
            }
            if ((fecha_nacimiento.Day >= 21 && fecha_nacimiento.Month == 01) || fecha_nacimiento.Day >= 19 && fecha_nacimiento.Month == 02)
            {
                Console.WriteLine("Tu signo es ACUARIO");
                Console.WriteLine("Amor: \nDinero: \n Bienestar: ");
            }
            if ((fecha_nacimiento.Day >= 20 && fecha_nacimiento.Month == 02) || fecha_nacimiento.Day >= 20 && fecha_nacimiento.Month == 03)
            {
                Console.WriteLine("Tu signo es PISCIS");
                Console.WriteLine("Amor: \nDinero: \n Bienestar: ");
            }
            Random rnd = new Random(DateTime.Now.Millisecond);

            String[] Frases_Amor = new string[] {"Día de revelaciones y decisiones importantes.",
            "La jornada se presentará tensa en la pareja.",
            "Procura mantener la serenidad y no hacer aquello que podría empeorar la situación.",
            "Buscarás el apoyo de tu pareja o de amigos para afrontar situaciones difíciles. ",
            "Tus inseguridades saldrán a relucir cuando personas del pasado de tu pareja vuelvan repentinamente a tu vida.",
            "Luego de un día agitado buscarás refugiarte en los brazos de tu pareja, para librarte de las tensiones de tu ambiente laboral."};

            String[] Frases_Dinero = new string[] {"Perderás la paciencia con tus subordinados el día de hoy.",
            "No podrás soportar más ciertas actitudes por parte de tu superior y decidirás tomar cartas en el asunto.",
            "Finalmente dejarás de lado aquel proyecto con el que has insistido tanto tiempo y ninguna ganancia te ha dejado.",
            "Comenzarás la semana con muy buenas noticias en tu ámbito laboral. ",
            "Ciertas cuestiones pendientes se desvanecen sin problemas.",
            "Se acerca la conclusión de tu proyecto más importante, pero vivirás horas de tensión y nerviosismo hasta que lo entregues." };

            String[] Frases_Bienestar = new string[] {"No permitas que el negativismo afecte tus sentidos y evite que veas las salidas.",
            "No dejes pasar un día de tu existencia sin sacarle algo positivo.",
            "No permitas que todo el trabajo que tienes invertido en proyectos personales se pierda simplemente porque alcanzar tus metas se ha hecho difícil."
            "Debes aprender de tus errores y continuar adelante.",
            "No subestimes la influencia que el karma puede llegar a tener en tu vida.",
               "Debes aprender a ser menos severo con los errores de las personas que te rodean." };

            Console.ReadKey();
        }
       
    }
    
}


