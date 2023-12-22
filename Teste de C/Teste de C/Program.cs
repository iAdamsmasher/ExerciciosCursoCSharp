using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_de_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, num, contador;

            contador = 0;
            Console.WriteLine("Digite um numero inteiro positivo:");
            num = int.Parse(Console.ReadLine());

            n = num;

            do
            {
                n = n / 10;
                contador++;
            } while (n > 0);
            Console.WriteLine("O número " + num + " tem " + n + " digitos");
        }
    }
}
