using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    class Periodo
    {
        private DateTime inicio;
        private DateTime final;
        public DateTime propInicio { get { return inicio; } set { inicio = value; } }
        public DateTime propFinal { get { return final; } set { final = value; } }

        public Periodo(DateTime inicio, DateTime final)
        {
            this.inicio = inicio;
            this.final = final;
        }





    }
}
