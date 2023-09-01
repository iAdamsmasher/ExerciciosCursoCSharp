using System;

namespace TempoDeUmEvento
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, N2, inicio, fim;
            string[] dd = Console.ReadLine().Split(' ');
            N = int.Parse(dd[1]);
    
            dd = Console.ReadLine().Split(' ');
            int hh = int.Parse(dd[0]);
            int mm = int.Parse(dd[2]);
            int ss = int.Parse(dd[4]);

            string[] dd2 = Console.ReadLine().Split(' ');
            N2 = int.Parse(dd2[1]);

            dd2 = Console.ReadLine().Split(' ');
            int hh2 = int.Parse(dd2[0]);
            int mm2 = int.Parse(dd2[2]);
            int ss2 = int.Parse(dd2[4]);

            inicio = N * 86400 + hh * 3600 + mm * 60 + ss;
            fim = N2 * 86400 + hh2 * 3600 + mm2 * 60 + ss2;

            int duracao = fim - inicio;

            int w = duracao / 86400;
            int resto = duracao % 86400;
            int x = resto / 3600;
            resto = resto % 3600;
            int Y = resto / 60;
            int Z = resto % 60;

            Console.WriteLine(w + " dia(s)");
            Console.WriteLine(x + " hora(s)");
            Console.WriteLine(Y + " minuto(s)");
            Console.WriteLine(Z + " segundo(s)");

        }
    }
}
