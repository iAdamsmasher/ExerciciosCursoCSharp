using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome:");
            string name = Console.ReadLine();

            Console.WriteLine("Quartos:");
            int nrooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Preço:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("sobrenome, idade, peso:");
            string[] vet = Console.ReadLine().Split(' ');
            string lastname = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Seu nome completo: " + name + " " + lastname);
            Console.WriteLine("Numero de quartos: " + nrooms);
            Console.WriteLine("Preco do produto: " + price.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("Seu ultimo nome : " + lastname + "\n idade:" + age + " \n peso:" + height.ToString("F2", CultureInfo.InvariantCulture));
           // Console.WriteLine("Sua idade: " + age);
            //Console.WriteLine("Sua Altura" + height.ToString(CultureInfo.InvariantCulture));
            
        }
    }
}
