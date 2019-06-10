using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeFundamentosEnCchar
{
    class Ejercicio22
    {
        public void tabla()
        {
            int num, result;

            Console.WriteLine("ingrese el numero a multiplicar: ");
            num = int.Parse(Console.ReadLine());

            for (int i=1; i<=0; i++) {

                result = num * 1;
                Console.WriteLine(num+" * "+i+" = "+result);
            }
            Console.WriteLine("");
            Console.Read();
        }
    }
}
