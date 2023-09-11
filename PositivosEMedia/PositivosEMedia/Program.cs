using System;
using System.Globalization;

namespace PositivosEMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, i, media;
            media = 0;
            int count = 0;
            //Console.WriteLine("entre com os valores:");
            for (i = 0; i < 6; i++)
            {
                N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (N >= 0)
                {
                    media += N; // mesmo que media = media + N
                    count++;    //mesmo que count = count + 1
                }
            }
            media = media / count;
            Console.WriteLine(count + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
