using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroIntefaces
{
    interface IColeccionable
    {
         string Titulo { get; set; }

        string Describir(Libro libro);
    
    
    }
}
