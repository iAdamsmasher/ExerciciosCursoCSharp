using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aprendizado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35682;
            int y = 20;
            string g = "Didi";
            char t = 'M';

            Console.WriteLine("Seu Nome é = " + g + (" e você tem ") + y + (" Anos"));
            Console.WriteLine("Seu salário é " + x.ToString(CultureInfo.InvariantCulture) + " Reais " + "e seu sexo é = " + t);

            Console.ReadLine();
        }
    }
}
