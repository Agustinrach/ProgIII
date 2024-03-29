using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cifrado
{
    class Program
    {
        static string abecedario = "aábcdeéfghiíjklmnñoópqrstuúüvwxyz";
        static void Main(string[] args)
        {
            String mensaje = ("kd wiqd géuúi tédbbúnq kdq wiqd iúígédíqsybyuqu");
            Console.WriteLine(descifrar(mensaje, 21));


            string descifrar(string msj, int desplazamiento)
            {
                String descifrado = "";
                if (desplazamiento > 0 && desplazamiento < abecedario.Length)
                {
                    //recorre caracter a caracter el mensaje a cifrar
                    for (int i = 0; i < msj.Length; i++)
                    {
                        int posicionCaracter = posicionAbecedario(mensaje[i]);
                        if (posicionCaracter != -1) //el caracter existe en la variable abc
                        {
                            int pos = posicionCaracter - desplazamiento;
                            while (pos < 0)
                            {
                                pos = pos + abecedario.Length;
                            }
                            //concatena al mensaje cifrado
                            descifrado += abecedario[pos];
                        }
                        else//si no existe el caracter no se cifra
                        {
                            descifrado += msj[i];
                        }
                    }

                }
                return descifrado;
            }

            int posicionAbecedario(char caracter)
            {
                for (int i = 0; i < abecedario.Length; i++)
                {
                    if (caracter == abecedario[i])
                    {
                        return i;
                    }
                }
                return -1;
            }
            Console.ReadKey();
        }
    }
}
