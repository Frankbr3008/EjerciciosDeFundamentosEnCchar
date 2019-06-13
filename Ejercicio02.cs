using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escriba un programa en C# para encontrar el máximo entre tres números.
namespace EjerciciosDeFundamentosEnCchar
{
    class Ejercicio02
    {
        public void MaximoEntreTresNumeros() {

            int x, y, z;

            Console.WriteLine("ingrese primer numero a comparar");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese segundo numero a comparar");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese tercer numero a comparar");
            z = int.Parse(Console.ReadLine());

            if (x > y && x > z)
            {
                Console.WriteLine("el numero" + x + "es el mayor");
            }
            else if (y > x && y > z)
            {
                Console.WriteLine("el numero" + y + "es el mayor");
            }
            else if (z > x && z > y)
            {
                Console.WriteLine("el numero" + z + "es el mayor");
            }
            else { Console.WriteLine("error 220"); }

            Console.ReadKey();
        }
        }
    }

