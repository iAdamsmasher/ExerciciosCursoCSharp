using System;

namespace TipoDeCombustivelURI1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int T1 = 0;
            int T2 = 0;
            int T3 = 0;
            int entrada = int.Parse(Console.ReadLine());
            while(entrada > 0 && entrada < 4 || entrada <= 0 || entrada > 4)
            {
                if (entrada == 1)
                {
                    T1 = T1 + 1;
                }
                else if (entrada == 2)
                {
                    T2 = T2 + 1;
                }
                else if (entrada == 3)
                {
                    T3 = T3 + 1;
                }
                entrada = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + T1);
            Console.WriteLine("Gasolina: " + T2);
            Console.WriteLine("Diesel: " + T3);
        }
    }
}
