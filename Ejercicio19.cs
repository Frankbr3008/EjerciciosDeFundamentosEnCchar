using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeFundamentosEnCchar
{
    class Ejercicio19
    {
        public void Suma() {

            int x, sumfin, contador = 0, r;

            for (x=1;x<=50;x++) {

                r = x;
                contador = r + contador;
            }
            { sumfin = contador;
                Console.WriteLine("la suma final es"+sumfin);
            }
            Console.ReadKey();
        }
    }
}
