using System;
using System.Globalization;

namespace MediasPonderadas_Beecrowd1079
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, i, mediaPond;
            N = double.Parse(Console.ReadLine());
            mediaPond = 0;
            for (i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

                mediaPond = (a * 2 + b * 3 + c * 5) / (2 + 3 + 5);
                Console.WriteLine(mediaPond.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
