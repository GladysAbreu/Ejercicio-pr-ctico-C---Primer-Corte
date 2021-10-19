using System;

namespace Proyectos
{
    class Program
    {
        static void Main(string[] args)
        {
           // Asignacion de valores de las variables
            int a = 8;
            int b = 3; 
            int c = 6;

           Console.WriteLine("A continuacion, se muestran diversas combinaciones numericas, las cuales son:");

           // Combinacion: aacb
           Console.WriteLine("Primera combinacion: " + a + a + c + b);

           // Combinacion: bca
           Console.WriteLine($"Segunda combinacion: {b}{c}{a}");

           // Combinacion: bcbc
           Console.WriteLine("Tercera combinacion: {0}{1}{2}{3}", b,c,b,c);
              
        }
    }
}
