using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExedenteAcumulativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta = 50.0;

            if (minutos > 100)
            {
                conta = conta + (minutos - 100) * 2.0;
            }
            Console.WriteLine("Valor a Pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
