using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
             double prom = 0;
             int suma = 0;
             for (int i = 0; i < 10; i++)
             {
                 Console.WriteLine("Ingrese un numero");
                 num = Convert.ToInt16(Console.ReadLine());
                 suma = suma + num;
             }
             prom = suma / 10;
             Console.WriteLine("El promedio es {0}",prom);
             Console.ReadKey(); 
           
        }
    }
}
