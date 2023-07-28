using System;
using System.Globalization;

namespace ImpostoDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            double renda, imposto,resto,soma;

            renda = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (renda <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                if (renda <= 3000.0)
                {
                    imposto = (renda - 2000.0) * 0.08;
                }
                else if (renda <= 4500)
                {
                    imposto = (renda - 3000.0) * 0.18 + 1000.0 * 0.08;
                }
                else
                {
                    imposto = (renda - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
                }
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
