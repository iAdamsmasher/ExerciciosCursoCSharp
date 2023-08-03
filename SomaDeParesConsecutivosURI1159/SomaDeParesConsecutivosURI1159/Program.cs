using System;

namespace SomaDeParesConsecutivosURI1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int saida = 0;
            while (x != 0)
            {
                if (x % 2 == 0)
                {
                    saida = (x + (x + 2)) + (x + 4) + (x + 6) + (x + 8);

                }
                else if (x % 2 != 0)
                {
                    saida = (x + 1) + (x + 3) + (x + 5) + (x + 7) + (x + 9);
                }
                Console.WriteLine(saida);
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}