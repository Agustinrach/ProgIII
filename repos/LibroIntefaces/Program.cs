using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroIntefaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("agustin", "100 años");
            Libro libro2 = new Libro("sofia", "luna de pluton");
            Libro libro3 = new Libro("maria", "cadena perpetua");
            Libro libro4 = new Libro("ale", "la biblia");
            Libro libro5 = new Libro("diego", "don quijote");

            Libro[] Biblioteca = new Libro[5] { libro1, libro2, libro3, libro4, libro5 };

            foreach (Libro valor in Biblioteca)
            {
                Console.WriteLine(valor.Autor);
            }
            Console.WriteLine("");

            Array.Sort(Biblioteca);
            
            foreach(Libro valor in Biblioteca)
            {
                Console.WriteLine(valor.Autor);
            }
            Console.ReadKey();
        }
    }
}
