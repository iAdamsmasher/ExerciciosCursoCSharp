using System;

namespace Revisão_de_Código
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] pares = new int[N];


            string[] posicoes = Console.ReadLine().Split(' ');
            int count = 0;

            for (int i = 0; i < N; i++)
            {
                if (int.Parse(posicoes[i]) % 2 == 0)
                {
                    pares[count] = int.Parse(posicoes[i]);
                    count++;
                }
            }
            for (int i = 0; i < pares.Length; i++)
            {
                if (pares[i] != 0)
                    Console.WriteLine("Valor alocado no vetor: " + pares[i]);
            }

            Console.WriteLine("Total de contagem: " + count);
            Console.ReadLine();


        }
    }
}
