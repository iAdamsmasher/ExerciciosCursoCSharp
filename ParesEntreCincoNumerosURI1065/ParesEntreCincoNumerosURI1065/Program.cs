using System;

namespace ParesEntreCincoNumerosURI1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, count, i;
            N = 0;
            i = 0;
            count = 0;
            for (i = 0; i < 5; i++)
            {
                N = int.Parse(Console.ReadLine());
                if (N % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count + " valores pares");
        }
    }
}
