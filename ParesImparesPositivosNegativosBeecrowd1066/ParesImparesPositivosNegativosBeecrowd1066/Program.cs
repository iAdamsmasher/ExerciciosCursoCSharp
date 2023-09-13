using System;


namespace ParesImparesPositivosNegativosBeecrowd1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, count, count2, count3, count4, i;
            count = 0;
            count2 = 0;
            count3 = 0;
            count4 = 0;
            i = 0;

            for (i = 0; i < 5; i++)
            {
                N = int.Parse(Console.ReadLine());
                if (N % 2 == 0)
                {
                    count++;
                    if (N > 0)
                    {
                        count3++;
                    }
                    if (N < 0)
                    {
                        count4++;
                    }
                }
                else if (N % 2 != 0)
                {
                    count2++;
                    if (N > 0)
                    {
                        count3++;
                    }
                    if (N < 0)
                    {
                        count4++;
                    }
                }
            }
            Console.WriteLine(count + " valor(es) par(es)");
            Console.WriteLine(count2 + " valor(es) impar(es)");
            Console.WriteLine(count3 + " valor(es) positivo(s)");
            Console.WriteLine(count4 + " valor(es) negativo(s)");
        }
    }
}
