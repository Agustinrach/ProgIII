using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    class Cliente
    {
        public String nombre { get; set; }
        public String tipo { get; set; }
        public int saldo { get; set; }

        public Cliente(string nombre, string tipo, int saldo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.saldo = saldo;
        }

        
    }
}

