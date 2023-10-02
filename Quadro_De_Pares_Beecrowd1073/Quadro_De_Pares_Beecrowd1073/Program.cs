using System;

namespace Quadro_De_Pares_Beecrowd1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, quadrado;
            N = int.Parse(Console.ReadLine());
            for (i = 2; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    quadrado = i * i;
                    Console.WriteLine(i + "^2 = " + quadrado);
                }
            }
        }
    }
}
