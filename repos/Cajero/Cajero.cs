using System;
using static Cajero.Cliente;

namespace Cajero
{
    class Cajero
    {
        public String direccion { get; set; }
        public int numero { get; set; }

        public Cajero(string direccion, int numero)
        {
            this.direccion = direccion;
            this.numero = numero;
        }
       
        public void sacarPlata(Cliente cliente, int plata, DateTime fecha)
        {
            if (cliente.tipo== "activo")
            {
                if (cliente.saldo - plata < 0)
                {
                    Console.WriteLine("CLIENTE ACTIVO intenta retirar {0}, su saldo es insificiente, presione 1 si desea retirar en concepto de adelanto de sueldo, presione 0 para salir", plata);
                    int opcion = int.Parse(Console.ReadLine());
                    if (opcion == 1)
                    {
                        if (cliente.saldo <= 20000)
                        {
                            Console.WriteLine("Puede sacar en concepto de adelanto de sueldo hasta 20000");
                        }
                        else
                        {
                            cliente.saldo = cliente.saldo - plata;
                        }
                    }
                    else { Console.WriteLine("Gracias!"); }
                }
                else
                {
                    cliente.saldo = cliente.saldo - plata;
                    Console.WriteLine("CLIENTE ACTIVO se retiro {0}, total {1}", plata, cliente.saldo);
                }
            }

            if (cliente.tipo == "pasivo")
            {
                if (cliente.saldo - plata < 0)
                {
                    Console.WriteLine("CLIENTE PASIVO intenta retirar {0}, su saldo es insificiente, presione 1 si desea retirar en concepto de adelanto de sueldo, presione 0 para salir", plata);
                    int opcion = int.Parse(Console.ReadLine());
                    if (opcion == 1)
                    {
                        if (cliente.saldo <= 10000)
                        {
                            Console.WriteLine("Puede sacar en concepto de adelanto de sueldo hasta 10000");
                        }
                        else
                        {
                            cliente.saldo = cliente.saldo - plata;
                        }
                    }
                    else { Console.WriteLine("Gracias!"); }
                }
                else
                {
                    cliente.saldo = cliente.saldo - plata;
                    Console.WriteLine("CLIENTE PASIVO se retiro {0}, total {1}", plata, cliente.saldo);
                }
            }
        }

        public void ingresarPlata(Cliente cliente, int plata, String fecha)
        {
            cliente.saldo = cliente.saldo + plata;
            Console.WriteLine("Nombre: {3} CLIENTE {2}, se ingreso {0} a su cuenta, total {1}, fecha:{4}", plata, cliente.saldo, cliente.tipo,cliente.nombre,fecha);
        }

        public void mostrarPlata(Cliente cliente)
        {
            Console.WriteLine("Nombre: {2}, Estado: {1}, Saldo: ${0}", cliente.saldo, cliente.tipo, cliente.nombre);
        }






    }
}
