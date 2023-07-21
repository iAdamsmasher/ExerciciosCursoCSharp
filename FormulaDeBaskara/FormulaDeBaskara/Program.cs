using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FormulaDeBaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, delta, x1, x2;

            string[] vet = Console.ReadLine().Split(' ');
           
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = (Math.Pow(B, 2.0) - (4 * A * C));
            x1 = ((-B + Math.Sqrt(delta)) / (2 * A));
            x2 = ((-B - Math.Sqrt(delta)) / (2 * A));

            if (A <= 0 || B <=0 || C <=0 || delta <=0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine("R1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
               /* Console.WriteLine("DELTA = " + delta, CultureInfo.InvariantCulture);
                Console.WriteLine("A = " + A, CultureInfo.InvariantCulture);
                Console.WriteLine("B = " + B, CultureInfo.InvariantCulture);
                Console.WriteLine("C = " + C, CultureInfo.InvariantCulture);*/
            }
        }
    }
}
