using System;

namespace TabuadaURI1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i;
            int tabuada;

            N = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                tabuada = i * N;
                Console.WriteLine(i + " x " +  N + " = " + tabuada);
            }
        }
    }
}
