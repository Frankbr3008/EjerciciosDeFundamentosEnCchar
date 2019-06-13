using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeFundamentosEnCchar
{
    class Ejercicio04
    {
        public void AñoBiciesto(){

            int año;

            Console.WriteLine("ingrese el año");
            año = int.Parse(Console.ReadLine());

            if (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0))
            {
                Console.WriteLine("el año" + año + "es Biciesto");
            }
            else {
                Console.WriteLine("el año" + año + "no es Biciesto");
            }
            Console.ReadKey();
        }
    }
}
