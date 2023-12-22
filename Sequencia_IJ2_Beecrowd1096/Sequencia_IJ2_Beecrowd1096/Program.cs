using System;

namespace Sequencia_IJ2_Beecrowd1096
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            j = 7;

            for (i = 1; i <= 9; i += 2)
            {
                Console.WriteLine("I=" + i + " j=" + j);
                Console.WriteLine("I=" + i + " j=" + (j - 1));
                Console.WriteLine("I=" + i + " j=" + (j - 2));
                j = j + 2;
            }
        }
    }
}
