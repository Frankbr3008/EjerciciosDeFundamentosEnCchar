using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeFundamentosEnCchar
{
    class Ejercicio07
    {
        public void Multiplos() {

            int n = 5, nn = 11,v, r, rr;

            Console.WriteLine("ingresar numero para comprobar si es multiplo de 5 o 11");
            v = int.Parse(Console.ReadLine());

            r = (n%v);
            rr = (nn%v);

            if (r == 0)
            {
                Console.WriteLine("el numero es divisible por 5");
            }
            else if (rr == 0)
            {
                Console.WriteLine("el numero es divisible por 11");
            }
            else {
                Console.WriteLine("el numero no es divisible ni por 5 ni por 11");
            }
            Console.ReadKey();
        }
    }
}
