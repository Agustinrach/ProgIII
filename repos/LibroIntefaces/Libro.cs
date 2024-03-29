using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroIntefaces
{
    class Libro :  IColeccionable, IComparable
    {
        private string autor;
        private string titulo;

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Titulo
        { 
            get { return titulo; } 
            set {titulo = value; } 
        }

        public Libro(string autor, string titulo)
        {
            this.autor = autor;
            this.titulo = titulo;
        }

        public string Describir(Libro libro)
        {
            return libro.ToString();
        }

        public int CompareTo(object obj)
        {
            if(obj == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
