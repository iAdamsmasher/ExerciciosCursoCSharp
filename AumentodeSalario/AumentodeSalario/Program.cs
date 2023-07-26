using System;
using System.Globalization;

namespace AumentodeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novoSalario, sobrado;
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.00)
            {
                sobrado = salario * 0.15;
                novoSalario = sobrado + salario;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + sobrado.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                sobrado = salario * 0.12;
                novoSalario = sobrado + salario;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + sobrado.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                sobrado = salario * 0.10;
                novoSalario = sobrado + salario;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + sobrado.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                sobrado = salario * 0.07;
                novoSalario = sobrado + salario;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + sobrado.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (salario > 2000.00)
            {
                sobrado = salario * 0.04;
                novoSalario = sobrado + salario;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + sobrado.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }
        }
    }
}
