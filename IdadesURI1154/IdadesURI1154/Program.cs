using System;
using System.Globalization;

namespace IdadesURI1154
{
    class Program
    {
        static void Main(string[] args)
        {
            double entrada = 0.0;
            double soma = 0.0;
            double cont = 0.0;
            double media;
            entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (entrada >= 0)
            {
                soma = soma + entrada;
                cont = cont + 1;
                entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            media = soma / cont;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
