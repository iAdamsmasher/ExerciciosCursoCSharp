using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateCodes
{
    class Program
    {
        static void Main(string[] args)
        {

            ChamarCalculadora();
        }

        static private void ChamarCalculadora()
        {
            Calculadora calc = new Calculadora();
            int result = calc.soma(5,5);
            int result2 = calc.sub(15, 2);
            int result3 = calc.mult(6, 6);
            Console.WriteLine("O resultado é : \n" + result.ToString() + "\n" + result2.ToString() + "\n" + result3.ToString());
        }
        static private void casasDec()
        {
            CasasDecimais cd = new CasasDecimais(1000.12, 1000.12);
           
            Console.WriteLine(cd.casaDecimal());
        }

    }
}
