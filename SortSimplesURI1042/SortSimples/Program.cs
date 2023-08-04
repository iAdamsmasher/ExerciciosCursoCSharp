using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int C = int.Parse(vet[2]);

            if (A < B && A < C)
            {
                Console.WriteLine(A);
                if (B < C)
                {
                    Console.WriteLine(B);
                    Console.WriteLine(C);
                }
                else
                {
                    Console.WriteLine(C);
                    Console.WriteLine(B);
                }
            }
            else if (B < C)
            {
                Console.WriteLine(B);
                if (A < C)
                {
                    Console.WriteLine(A);
                    Console.WriteLine(C);
                }
                else
                {
                    Console.WriteLine(C);
                    Console.WriteLine(A);
                }
            }
            else
            {
                Console.WriteLine(C);
                if (B < A)
                {
                    Console.WriteLine(B);
                    Console.WriteLine(A);
                }
                else
                {
                    Console.WriteLine(A);
                    Console.WriteLine(B);
                }
            }
            Console.WriteLine();
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
    }
}

