using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ancho = 75;
            int alto = 22;

            // Dibuja la parte superior del marco
            for (int i = 0; i < ancho; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // Dibuja los lados izquierdo y derecho del marco
            for (int i = 0; i < alto - 2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < ancho - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();
            }

            // Dibuja la parte inferior del marco
            for (int i = 0; i < ancho; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
