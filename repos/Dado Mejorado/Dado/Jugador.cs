using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dado
{
    class Jugador
    {
        private int saldo;
        private string nombre;
        public string propNombre { get { return nombre; } set { nombre = value; } }
        public int propSaldo { get { return saldo; } set { saldo = value; } }
        public Jugador(int saldo, string nombre)
        {
            this.saldo = saldo;
            this.nombre = nombre;
        }
    }
}
