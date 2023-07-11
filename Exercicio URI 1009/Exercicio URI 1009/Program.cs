using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_URI_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, totalVenda, salarioTotal;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //salarioTotal = totalVenda * 15.0 / 100 + salarioFixo;
            salarioTotal = (totalVenda * 0.15) + salarioFixo;

            Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
