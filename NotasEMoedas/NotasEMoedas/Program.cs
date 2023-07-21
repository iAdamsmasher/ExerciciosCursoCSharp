using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NotasEMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            int quociente, resto, nota, moeda;

            N = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // Vamos multiplicar N por 100 e forçar a conversão para int.
            // Desse modo, por exemplo, 576.73 vai se tornar 57673

            // Vamos tambem somar 0.5 antes de converter, para assegurar 
            // que o numero seja devidamente arredondado, pois o tipo double
            // as vezes da problema de arredondamento (por exemplo: se digitarmos
            // 576.81 e multiplicarmos por 100, o resultado sera 57680.99999999,
            // dai o casting resultaria em 57680 e nao 57681 como desejado)

            int cem =(int)(Math.Floor(N / 100));

            int cinquenta = (int)(Math.Floor((N % 100) / 50));

            int vinte = (int)(Math.Floor((N % 50) / 20));

            int dez = (int)(Math.Floor(N % 20) / 10);

            int cinco = (int)(Math.Floor(N % 10) / 5);

            int dois = (int)(Math.Floor(N % 5) / 2);

            int um = (int)(Math.Floor((N % 5) % 2));

            int fifCen = (int)(Math.Floor((N % 1) / 0.5));


            Console.WriteLine(cem + " de R$ 100,00 ");
            Console.WriteLine(cinquenta + " de R$ 50,00 ");
            Console.WriteLine(vinte + " de R$ 20,00 ");
            Console.WriteLine(dez + " de R$ 10,00 ");
            Console.WriteLine(cinco + " de R$ 5,00 ");
            Console.WriteLine(dois + " de R$ 2,00 ");
            Console.WriteLine(um + " de R$ 1,00 ");
            Console.WriteLine(fifCen + "0,5");





        }
    }
}
