using System;
using System.Globalization;


namespace ExercicioProposto1Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] numeros = new double[N];
            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                numeros[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
            }
            double maior = numeros[0];
            int posicaoMaior = 0;

            for (int i = 0; i < N; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                    posicaoMaior = i;
                }
            }
            Console.WriteLine(maior.ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine(posicaoMaior);

            Console.ReadLine();
        }
    }
}
