using System;
namespace Resto2_Beecrowd1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i;
            N = int.Parse(Console.ReadLine());
            for (i = 0; i < 10000; i++)
            {
                if (i % N == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
