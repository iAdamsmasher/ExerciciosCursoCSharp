﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LerOMenorNumeroInteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            if (a < b && a < c)
            {
                Console.WriteLine("MENOR = " + a);
            }
            else if (b < c)
            {
                Console.WriteLine("MENOR = " + b);
            }
            else
            {
                Console.WriteLine("MENOR = " + c);
            }
        }
    }
}
