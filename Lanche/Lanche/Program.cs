using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lanche
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            int quantidade;
            double numero;
            double c1, c2, c3, c4, c5;

            string[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            if (codigo == 1)
            {
                numero = 4.00 * quantidade;
                Console.WriteLine("Total: R$ " + numero.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 2)
            {
                numero = 4.50 * quantidade;
                Console.WriteLine("Total: R$ " + numero.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 3)
            {
                numero = 5.00 * quantidade;
                Console.WriteLine("Total: R$ " + numero.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 4)
            {
                numero = 2.00 * quantidade;
                Console.WriteLine("Total: R$ " + numero.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 5)
            {
                numero = 1.50 * quantidade;
                Console.WriteLine("Total: R$ " + numero.ToString("F2", CultureInfo.InvariantCulture));
            }
        }

    }
}
