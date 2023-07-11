using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções_Matemáticas
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.0;
            double y = 9.0;
            double z = -5.0;
            double A, B, C; 

             A = Math.Sqrt(x);
             B = Math.Sqrt(y);
             C = Math.Sqrt(25.0);
            
            Console.WriteLine("A Raiz quadrada de " + x + " = " + A);
            Console.WriteLine("A Raiz quadrada de " + y + " = " + B);
            Console.WriteLine("A raiz quadrada de 25 = " + C );

            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(y, 4.0);

            Console.WriteLine(x + " Elevado a " + y + " = " + A);
            Console.WriteLine(x + " Elevado a " + 2.0 + " = " + B);
            Console.WriteLine(y + " Elevado a " + 4.0 + " = " + C);

            A = Math.Abs(x);
            B = Math.Abs(y);
            C = Math.Abs(-25.0);

            Console.WriteLine("O modulo de " + x + " = " + A);
            Console.WriteLine("O modulo de " + y + " = " + B);
            Console.WriteLine("O modulo de -25.0 = " + C);



            //Raiz Quadrada -->
            double delta;
            double b = 2;
            double a = 5;
            double c = 4;
            double x1;
            double x2;

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);






        }
    }
}
