using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_URI_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, TRIANGULO_RETANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO, pi;
            pi = 3.14159;

            string[] vet;
            vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1],CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            TRIANGULO_RETANGULO  = (A * C) / 2;
            CIRCULO = pi * Math.Pow(C, 2.0);
            TRAPEZIO = ((A + B) * C) / 2.0;
            QUADRADO = Math.Pow(B, 2.0);
            RETANGULO = A * B;

            Console.WriteLine("TRIANGULO: " + TRIANGULO_RETANGULO.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + CIRCULO.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + TRAPEZIO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + QUADRADO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + RETANGULO.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
