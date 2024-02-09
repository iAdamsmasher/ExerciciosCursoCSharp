using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            double[] numeros = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                numeros[i] = double.Parse(s[0]);

            }

            double soma = 0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + numeros[0];
            }
            double media;
            media = soma / N;

            Console.WriteLine(soma);
            Console.WriteLine(media);

            Console.ReadLine();

        }
    }
}
