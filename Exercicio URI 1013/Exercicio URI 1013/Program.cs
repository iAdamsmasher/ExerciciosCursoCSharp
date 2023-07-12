using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_URI_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            double consumoMédio, X, Y;
            X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumoMédio = (X / Y);

            Console.WriteLine(consumoMédio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
