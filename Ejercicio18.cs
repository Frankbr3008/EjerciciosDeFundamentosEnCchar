﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeFundamentosEnCchar
{
    class Ejercicio18
    {
        public void NumerosImares()
        {
            int i, impar = 0; 
            for (i = 0; i <= 100; i ++)
            {
                if (i % 2 != 0)
                {

                    Console.WriteLine("{0}|",i);
                    impar++;
                }
                Console.WriteLine("\n\n");
            }
            Console.ReadKey();
        }
    }
}
