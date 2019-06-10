using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeFundamentosEnCchar
{
    class Ejercicio08
    {
        public void VocaloNo() {

            string letra;

            Console.WriteLine("ingrese una letra");
            letra = Console.ReadLine();

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u") {

                Console.WriteLine("la letra es una vocal");
            } else if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u"||letra =="b"|| letra =="c"|| letra == "d"|| letra == "f"|| letra == "g"|| letra == "h"|| letra == "j"|| letra == "k"|| letra == "l"|| letra == "m"|| letra == "n"||
                letra == "n"|| letra == "p"|| letra == "q"|| letra == "r"|| letra == "s"|| letra == "t"|| letra == "v"|| letra == "w"|| letra == "x"|| letra == "y"|| letra == "z") {

                Console.WriteLine("la letra es una consonante");
            }

        }
    }
}
