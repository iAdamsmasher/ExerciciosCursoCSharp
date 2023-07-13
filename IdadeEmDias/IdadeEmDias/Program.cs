using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, anos, meses, dias, resto;

            N = int.Parse(Console.ReadLine());                                //1 ano = 12 meses = 365dias
                                                                              // 1 mês = 30 dias
            anos = N / 365;
            resto = N % 365;

            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
