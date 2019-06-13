using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeFundamentosEnCchar
{
    class Ejercicio12
    {
        public void DiaMes() {

            int xdia;

            Console.WriteLine("ingrese el numero del mes \n 1.- Enero\n 2.- Febrero \n 3.-Marzo \n 4.-Abril" +
                "\n 5.- Mayo\n 6.-Junio\n 7.-Julio\n 8.-Agosto\n 9.-Septiembre\n 10.-Octubre\n 11.-Noiembre\n 12.-Diciembre");
            xdia = int.Parse(Console.ReadLine());

            switch (xdia)
            {

                case 1:
                    Console.WriteLine("Enero tiene 31 dias"); break;
                case 2:
                    Console.WriteLine("Febrero tiene 28 dias o 29 si es año biciesto"); break;
                case 3:
                    Console.WriteLine("Marzo tiene 31 dias"); break;
                case 4:
                    Console.WriteLine("Abril tiene 30 dias"); break;
                case 5:
                    Console.WriteLine("Mayo tiene 31 dias"); break;
                case 6:
                    Console.WriteLine("Junio tiene 30 dias"); break;
                case 7:
                    Console.WriteLine("Julio tiene 31 dias"); break;
                case 8:
                    Console.WriteLine("Agosto tiene 31 dias"); break;
                case 9:
                    Console.WriteLine("Septiembre tiene 30 dias"); break;
                case 10:
                    Console.WriteLine("Octubre tiene 31 dias"); break;
                case 11:
                    Console.WriteLine("Noviembre tiene 30 dias"); break;
                case 12:
                    Console.WriteLine("Diciembre tiene 31 dias"); break;
                default:
                    Console.WriteLine("No hay registro"); break;
            }
            Console.ReadKey();
        }
    }
}
