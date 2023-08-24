using System;

namespace NumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i >= 0 && i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
