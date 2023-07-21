using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Exercicio_Resolvido_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, resultado;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = nota1 + nota2;
            Console.WriteLine("NOTA FINAL = " + resultado.ToString("F1", CultureInfo.InvariantCulture));

            if (resultado < 60.0)
            {
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Aprovado");
            }


        }
    }
}
