using System;
using System.Globalization;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, MEDIA;                                                 //Na media ponderada, divide-se pela soma dos pesos aplicados a cada valor de n entradadas.
            A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            MEDIA = (A * 3.5 + B * 7.5) / 11;
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
