using System;

namespace Sequencia_IJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j;
            for (j = 60; j >= 0; j = j - 5)
            {
                Console.WriteLine("I=" + i + " J=" + j);
                i = i + 3;
            }
        }
    }
}
