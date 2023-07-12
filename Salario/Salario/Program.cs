using System;
using System.Globalization;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeNumber, h;
            double SALARY, salaryhour;

            employeeNumber = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());
            salaryhour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            SALARY = salaryhour * h;

            Console.WriteLine("NUMBER = " + employeeNumber);
            Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
