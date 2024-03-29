using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cajero cajero1 = new Cajero("9 de julio", 1);
            Cliente cliente1 = new Cliente("oscar","activo", 200);

            cajero1.ingresarPlata(cliente1, 250, "12/04/2022");
            cajero1.mostrarPlata(cliente1);
                



            Console.ReadKey();
        }
    }
}
