using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeFundamentosEnCchar
{
    class Ejercicio20
    {
        private void SumsPares(int[]a) {

            int sumadepares = 0, sumatotal = 0;
            Console.WriteLine("Losvalores de las entradas");
            for (int i=0; i<a.Length;i++) {
                Console.WriteLine("Posicion " + i + "es" + a[i]);
            }
            Console.WriteLine("Numeros Pares");
            for (int j = 0; j < a.Length; j++) {

                if (a[j]%2==0) {
                    Console.WriteLine("La posicion" + j + "contiene el numero" + a[j] + " por lo tanto es par");
                }
                sumatotal += a[j];
            }
            Console.WriteLine("suma de los numeros pares"+sumadepares);
            Console.WriteLine("suma de todos los numeros del Array son" + sumatotal);
            Console.ReadKey();

        }
    }
}
