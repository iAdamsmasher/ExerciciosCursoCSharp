using System;

namespace Numeros_Impares_Beecrowd1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int X = int.Parse(Console.ReadLine());
            for (i = 1; i <= X; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
