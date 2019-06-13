using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escriba un programa en C# para encontrar el máximo entre dos números.
namespace EjerciciosDeFundamentosEnCchar
{   
    public class Ejercicio01
    {
        public void MaximoEntreNumeros(){
            int x, y;

            Console.WriteLine("ingrese primer numero a comparar");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese segundo numero a comparar");
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("el numero" + x + "es el mayor");
            }
            else if (y > x)
            {
                Console.WriteLine("el numero" + y + "es el mayor");
            }
            else {
                Console.WriteLine("no puso algun numero");
            }

            Console.ReadKey();

        }
    }
}
