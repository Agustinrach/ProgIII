using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbol_y_grafo
{
    class Nodo
    {
        string dato;
        Nodo nodoIzq;
        Nodo nodoDer;

        public Nodo(string dato, Nodo nodoIzq, Nodo nodoDer)
        {
            this.dato = dato;
            this.nodoIzq = nodoIzq;
            this.nodoDer = nodoDer;
        }
    }
}
