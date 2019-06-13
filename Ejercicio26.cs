using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeFundamentosEnCchar
{
    class Ejercicio26
    {
        public void MayorMenor()
        {
            int[] array = new int[10];
            int menor = 0, mayor = 0;

            for (int i = 0; i < array.Length; i++)
            {

                Console.Write("Digite Numero ");
                array[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {

                    mayor = array[i];
                    menor = array[i];
                }
                else
                {

                    if (array[i] < menor)
                    {

                        menor = array[i];
                    }
                    if (array[i] > mayor)
                    {

                        mayor = array[i];
                    }
                }

            }
            Console.WriteLine("El mayor es " + mayor);
            Console.WriteLine("El menor es " + menor);
            Console.ReadKey();
        }
    }
}
