using System;
using System.Globalization;

namespace NumerosPositivosURI1060
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double n = 0.0;
            for (int i = 0; i < 6; i++)
            {
                n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (n > 0)
                    count++;
            }
            Console.WriteLine(count.ToString() + " valores positivos");
        }
    }
}
