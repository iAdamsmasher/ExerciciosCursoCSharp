using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioResolvido1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double largura, comprimento, area, preco, precoTotal;
            //largura = 10.0;
            // comprimento = 30.0;
            // preco = 200.00;


            //area = largura * comprimento;
            // precoTotal = area * preco;

            //Console.WriteLine("A area total da propriedade é : " + area.ToString( "F2",CultureInfo.InvariantCulture));
            //Console.WriteLine("O preco total da propriedade é : " + precoTotal.ToString( "F2" ,CultureInfo.InvariantCulture));


            Console.Write("Digite a Largura da casa: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o Comprimento da casa: ");
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o preço do m² da casa: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = (largura * comprimento);

            Console.WriteLine("A area total da casa é : " + area.ToString("F2", CultureInfo.InvariantCulture) + "m²");
            Console.WriteLine("O valor da casa é : R$" + (preco * area).ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
