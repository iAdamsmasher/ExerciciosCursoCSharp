using System;
using System.Globalization;

namespace Exercicio2Vetores
{
    class Program
    {

        static void Main(string[] args)
        {
            int N;
            double[] vet;
            double soma = 0;
            double media = 0;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                soma = vet[i] + soma;
            }
            media = soma / N;
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
