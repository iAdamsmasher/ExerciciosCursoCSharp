using System;
using System.Globalization;

namespace Par_Ou_Impar_Beecrowd1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, X;
            N = int.Parse(Console.ReadLine());
            for (i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (X > 0 && X % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                if (X < 0 && X % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                if (X > 0 && X % 2 != 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                if (X < 0 && X % 2 != 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                if (X == 0)
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
