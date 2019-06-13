using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeFundamentosEnCchar
{
    class Ejercicio24
    {
        public void cubo()
        {
            int NUM = 0;
            int RESUL = 0;
            string cadena;
            Program ob = new Program();
            Console.Write("DIGITE UN NÚMERO: ");
            cadena = Console.ReadLine();
            NUM = int.Parse(cadena);
            RESUL = ob.CUBO(NUM);
            Console.Write("EL CUBO DE {0} ES: {1} ", NUM, RESUL);
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();

        }
        private int CUBO(int AUX)
        {
            return AUX * AUX * AUX;
          
        }
        
    }
    }

