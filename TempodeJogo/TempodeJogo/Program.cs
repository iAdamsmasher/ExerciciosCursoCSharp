using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempodeJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, result;
            //1h = 60min = 3600s
            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            result = B - A;
            if (A == B)
            {
                result = 24;

            }
            else if (B < A)
            {
                B += 24;
                result = B - A;
            }

            Console.WriteLine("O JOGO DUROU " + result + " HORA(S)");


        }
    }
}
