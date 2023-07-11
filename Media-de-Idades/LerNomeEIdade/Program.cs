using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace LerNomeEIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            double idade1, idade2, media;

            //nome1 = Console.ReadLine();                                               1º Forma de fazer
            // nome2 = Console.ReadLine();
            // idade1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            // idade2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            string[] vet;                                                              //2º Forma de fazer
            vet = Console.ReadLine().Split(' ');
            nome1 = vet[0];
            idade1 = double.Parse(vet[1]);
            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            idade2 = double.Parse(vet[1]);

            media = (idade1 + idade2) / 2;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1",CultureInfo.InvariantCulture) + " anos ");
            Console.ReadLine();


        }
    }
}
