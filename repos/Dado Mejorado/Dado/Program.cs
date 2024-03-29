using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EMPEZAR A JUGAR? Si(1) - No(Cualquier tecla)");
            int empezar = int.Parse(Console.ReadLine());
            if(empezar == 1)
            {
                Console.WriteLine("Ingrese en nombre del jugador 1");
                String nombre1 = Console.ReadLine();
                Console.WriteLine("Ingrese en nombre del jugador 2");
                String nombre2 = Console.ReadLine();

                Jugador jugador1 = new Jugador(100, nombre1);
                Jugador jugador2 = new Jugador(100, nombre2);
                

                Console.WriteLine("JUGADOR 1 : NOMBRE: {0}, SALDO: ${1}",jugador1.propNombre,jugador1.propSaldo);
                Console.WriteLine("JUGADOR 2 : NOMBRE: {0}, SALDO: ${1}", jugador2.propNombre, jugador2.propSaldo);



            }
            else { Console.WriteLine("GRACIAS!"); }


           
            


            Console.ReadKey();
        }
    }
}
