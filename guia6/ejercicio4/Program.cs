using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("ingrese dos valores enteros");
              int valor1 = Convert.ToInt32(Console.ReadLine());
              int valor2 = Convert.ToInt32(Console.ReadLine());
              int primero;
              int segundo;
              if (valor1 <= valor2)
              {
                  primero = valor1;
                  segundo = valor2;
              }
             else
             {
                  primero = valor2;
                  segundo = valor1;
             }
            Console.WriteLine($"Los números divisibles por 2 y 3 entre {primero} y {segundo} son:");
              for (int i= primero; i <= segundo; i++)
              {
                 if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
              }
            Console.ReadKey();
        }
    }
}
