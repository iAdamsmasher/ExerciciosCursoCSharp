using System;

namespace OMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s, maiorAB, maior;
            string[] vet;
            vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            s = int.Parse(vet[2]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;
            maior = (maiorAB + s + Math.Abs(maiorAB - s)) / 2;


            Console.WriteLine(maior + " eh o maior");
        }
    }
}
