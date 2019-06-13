using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeFundamentosEnCchar
{
    class Ejercicio03
    {
        public void NumeroPar() {
            int valor;

            Console.WriteLine("ingrese numero comprobar");
            valor = int.Parse(Console.ReadLine());

            if ((valor % 2) == 0)
            {
                Console.WriteLine("el numero" + valor + "es par");
            }
            else {
                Console.WriteLine("el numero" + valor + "es impar");
            }

            Console.ReadKey();
        }
    }
}
