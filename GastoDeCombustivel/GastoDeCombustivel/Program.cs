using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GastoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoGasto, velocidadeMedia;
            double litros;

            tempoGasto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            velocidadeMedia = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            litros = (double)(tempoGasto * velocidadeMedia) / 12;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
