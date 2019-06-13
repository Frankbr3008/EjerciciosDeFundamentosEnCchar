using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeFundamentosEnCchar
{
    class Ejercicio23
    {
        public void digitos()
        {
            int valor;

            Console.WriteLine("Programa que dice cuantos digitos tiene un numero menor a 1000");
            do
            {
                Console.WriteLine("Digite un numero entre 0 y 999");
                valor = int.Parse(Console.ReadLine());

                if (valor >= 100)
                {
                    Console.WriteLine("El numero tiene tres digitos");
                    Console.ReadLine();
                }
                else if (valor >= 10)
                {
                    Console.WriteLine("El numero tiene dos digitos");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("El numero tiene un digito");
                    Console.ReadLine();
                }

            } while (valor != 0);
            Console.WriteLine("Al digital cero el programa termina...");
            Console.ReadKey();
        }
        
    }
    }

