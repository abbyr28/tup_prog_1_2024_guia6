using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            Console.WriteLine("Ingrese un numero natural");
            int valor = Convert.ToInt32(Console.ReadLine());
            if (valor > 0)
            {
                for (int i = 1; i <= valor; i++)
                {
                    suma = suma + i;
                }
            } else
            {
                Console.Write("No es un numero natural");
            }
            Console.WriteLine($"La suma es: {suma}");
            Console.ReadKey();
        }
    }
}
