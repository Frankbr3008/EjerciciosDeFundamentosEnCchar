using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeFundamentosEnCchar
{
    class Ejercicio21
    {
        public void sumaimapar()
        {
            int sumaimpar=0,r;
            for (int i=1; i<=10;i++) {
                if (i%2 !=0) {

                    r = sumaimpar + i;

                    Console.WriteLine("La suma de los impares es" + r);
                }
            }
            Console.ReadKey();
        }
    }
}
