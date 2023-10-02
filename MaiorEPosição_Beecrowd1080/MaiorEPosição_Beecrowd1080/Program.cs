using System;

namespace MaiorEPosição_Beecrowd1080
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, i, count, maior, posicao;
            maior = int.Parse(Console.ReadLine());
            posicao = 1;
            for (i = 1; i <= 10; i++)
            {
                N = int.Parse(Console.ReadLine());

                if (N > maior)
                {
                    maior = N;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}
