using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeFundamentosEnCchar
{
    class Ejercicio16
    {
        public void Alfabeto() {

            char letra = 'A';

            while (letra <= 'Z')
            {
                Console.Write("-" + letra);

                letra++;

            }
            Console.ReadKey();
        }
    }
}
