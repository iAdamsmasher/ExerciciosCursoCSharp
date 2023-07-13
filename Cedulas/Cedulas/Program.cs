using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, notasNecessarias, resto, nota;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            resto = N;

            nota = 100;
            notasNecessarias = resto / nota;
            Console.WriteLine(notasNecessarias + " nota(s) de R$" + nota + ",00");
            resto = resto % nota;

            nota = 50;
            notasNecessarias = resto / nota;
            Console.WriteLine(notasNecessarias + " nota(s) de R$" + nota + ",00");
            resto = resto % nota;

            nota = 20;
            notasNecessarias = resto / nota;
            Console.WriteLine(notasNecessarias + " nota(s) de R$" + nota + ",00");
            resto = resto % nota;

            nota = 10;
            notasNecessarias = resto / nota;
            Console.WriteLine(notasNecessarias + " nota(s) de R$" + nota + ",00");
            resto = resto % nota;

            nota = 5;
            notasNecessarias = resto / nota;
            Console.WriteLine(notasNecessarias + " nota(s) de R$" + nota + ",00");
            resto = resto % nota;

            nota = 2;
            notasNecessarias = resto / nota;
            Console.WriteLine(notasNecessarias + " nota(s) de R$" + nota + ",00");
            resto = resto % nota;

            Console.WriteLine(resto + " nota(s) de R$ 1,00");

        }
    }
}
