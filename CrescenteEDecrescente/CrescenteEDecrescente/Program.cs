using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrescenteEDecrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[] ordem = Console.ReadLine().Split(' ');
            x = int.Parse(ordem[0]);
            y = int.Parse(ordem[1]);

            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                ordem = Console.ReadLine().Split(' ');
                x = int.Parse(ordem[0]);
                y = int.Parse(ordem[1]);
            }
            Console.ReadLine();
        }
    }
}
