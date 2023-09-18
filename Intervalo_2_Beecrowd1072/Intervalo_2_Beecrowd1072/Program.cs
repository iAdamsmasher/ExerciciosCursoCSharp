using System;

namespace uri1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, X, count_in, count_out;
            N = int.Parse(Console.ReadLine());

            count_in = 0;
            count_out = 0;

            for (i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20)
                {
                    count_in++;
                }
                else
                {
                    count_out++;
                }
            }
            Console.WriteLine(count_in + " in");
            Console.WriteLine(count_out + " out");
        }
    }
}