using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeFundamentosEnCchar
{
    class Ejercicio06
    {
        public void PositioNegativo() {

            int num;

            Console.WriteLine("ingrese un numero");
            num = int.Parse(Console.ReadLine());

            if (num == 0) {
                Console.WriteLine("su numero es neutro(0)");
            } else if (num >= 1) {
                Console.WriteLine("su numero es positivo");
            } else if (num<= -1) {
                Console.WriteLine("su numero es negativo");
            }Console.ReadKey();
        } 
    }
}
