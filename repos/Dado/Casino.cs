using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dado
{
    class Casino
    {
        
        Jugador jugador;

        private int pozo = 10000;
        public int propPozo { get { return pozo; } set { pozo = value; } }

        Dado dado = new Dado(12);
        public void apostarConservador (Jugador Jugador, int plata)
        {
            Console.WriteLine("A qué numero le va a apostar?");
            int nroApostado = int.Parse(Console.ReadLine());
            int resultado = dado.tirarDado();

            if(nroApostado == resultado)
            {
                jugador.propSaldo += plata * 2;
                pozo -= plata * 2;
                Console.WriteLine("Salio el {0}, Ganaste!", resultado);
            }
            else
            {
                jugador.propSaldo -= plata;
                pozo += plata;
                Console.WriteLine("Salio el {0}, perdiste!");
            }

        }
        public void apostarArriesgado(Jugador Jugador, int plata) { }
        public void apostarDesesperado(Jugador Jugador, int plata) { }



    }
}
