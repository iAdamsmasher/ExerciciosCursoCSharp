using System;

namespace MaiorEPosicao_Beecrowd1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, maior, posicao;
            posicao = 1;
            maior = int.Parse(Console.ReadLine());
            for (int i = 2; i <= 100; i++)
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
