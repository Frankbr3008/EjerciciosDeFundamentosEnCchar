using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeFundamentosEnCchar
{
    class Ejercicio11
    {
        public void DiasSemana() {

            int xdia;

            Console.WriteLine("ingrese el numero del dia de la semana \n 1.- Domingo\n 2.- Lunes \n 3.-Martes \n 4.-Miercoles"+
                "\n 5.- Jueves\n 6.-Viernes\n 7.-Sabado");
            xdia = int.Parse(Console.ReadLine());

            switch (xdia) {

                case 1:
                    Console.WriteLine("Dia Domingo"); break;
                case 2:
                    Console.WriteLine("Dia lunes");break;
                case 3:
                    Console.WriteLine("Dia Martes");break;
                case 4:
                    Console.WriteLine("Dia Miercoles");break;
                case 5:
                    Console.WriteLine("Dia Jueves");break;
                case 6:
                    Console.WriteLine("Dia Viernes");break;
                case 7:
                    Console.WriteLine("Dia Sabado");break;
                default:
                    Console.WriteLine("No hay registro");break;
            }
            Console.ReadKey();
        }
    }
}
