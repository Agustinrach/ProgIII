using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dado
{
    class Dado
    {
       Random random = new Random();
       private int CantidadCaras;

        public Dado(int cara)
        {
            this.CantidadCaras = cara;
        }

                      
        public int tirarDado()
        {
            int resultado = random.Next(2, CantidadCaras + 1);

            return resultado;
        }


    }
}
