using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz mat = new Matriz();
            mat.mostrar();
            Console.ReadLine();
        }

    }
    class Matriz
    {
        int[] m = new int[10];

        public Matriz()
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                m[i] = rand.Next(0, 30);
            }
        }
        public void mostrar()
        {
            foreach (var item in m)
            {
                Console.WriteLine(item);
            }
        }

    }
}

