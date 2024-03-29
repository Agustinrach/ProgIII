using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    class Program
    {
        static void Main(string[] args)
        {

        int c = 4;
        int b = 6;
        string s = "s";
        Console.WriteLine("salida:");

            while (true)
            {
                Console.WriteLine("salida:" + (c += 1));

                if (c<= 9)
                {
                    break;
                }

            }
        }
    }
}

