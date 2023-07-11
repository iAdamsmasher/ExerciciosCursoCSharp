using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double VOLUME, pi, r;
            pi = 3.14159;

            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            VOLUME = (4.0 / 3) * pi * Math.Pow(r, 3);
            Console.WriteLine("VOLUME = " + VOLUME.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

