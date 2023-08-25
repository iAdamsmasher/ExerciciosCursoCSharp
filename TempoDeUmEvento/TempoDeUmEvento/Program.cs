using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempoDeUmEvento
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, minutos, segundos, N, resto, tempo, NN;
            N = int.Parse(Console.ReadLine());

            string[] evento = Console.ReadLine().Split(' ');
            N = int.Parse(evento[1]);

            evento = Console.ReadLine().Split(' ');
            int hh = int.Parse(evento[0] + " : ");
            int mm = int.Parse(evento[1] + " : ");
            int ss = int.Parse(evento[2] + " : ");

            evento = Console.ReadLine().Split(' ');
            NN = int.Parse(evento[1]);

            evento = Console.ReadLine().Split(' ');
            int hh2 = int.Parse(evento[0] + " : ");
            int mm2 = int.Parse(evento[1] + " : ");
            int ss2 = int.Parse(evento[2] + " : ");

        }
    }
}
