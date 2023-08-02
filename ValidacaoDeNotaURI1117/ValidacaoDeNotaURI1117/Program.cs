using System;
using System.Globalization;

namespace ValidacaoDeNotaURI1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota, media, soma;
            int cont;
            cont = 0;
            soma = 0.0;
            media = 0.0;

            while (cont < 2)
            {
                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (nota >= 0.0 && nota <= 10.0)
                {
                    soma = soma + nota;
                    cont = cont + 1;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }
            media = soma / cont;
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
