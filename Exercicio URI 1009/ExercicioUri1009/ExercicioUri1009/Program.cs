using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioUri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeDoVendedor;
            double salariofixo, montanteTotal, totalReceber;

            nomeDoVendedor = Console.ReadLine();
            salariofixo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            montanteTotal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //totalReceber = (((salariofixo * 15) / 100) + montanteTotal);
            totalReceber = ((montanteTotal * 0.15) + salariofixo);

            Console.WriteLine("TOTAL = R$ " + totalReceber.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
