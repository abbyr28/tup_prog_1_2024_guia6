using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la base del rectángulo:");
            double baseRectangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectángulo:");
            double alturaRectangulo = Convert.ToDouble(Console.ReadLine());
         
            int anchoPantalla = Console.WindowWidth; //Establece el ancho de la ventana de la consola en columnas. 
            int altoPantalla = Console.WindowHeight; //Establece la altura de la ventana de la consola en filas.

            if (baseRectangulo > anchoPantalla || alturaRectangulo > altoPantalla)
            {
                Console.WriteLine("El dibujo no cabe en la pantalla.");
            }
            else
            {
                for (int fila = 0; fila < alturaRectangulo; fila++)
                {
                    for (int columna = 0; columna < baseRectangulo; columna++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
