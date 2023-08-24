using System;

namespace DDDUri1050
{
    class Program
    {
        static void Main(string[] args)
        {
            int discagem = int.Parse(Console.ReadLine());
 
            if (discagem == 61)
            {
                Console.WriteLine("Brasilia");
            }
            else if (discagem == 71)
            {
                Console.WriteLine("Salvador");
            }
            else if (discagem == 11)
            {
                Console.WriteLine("Sao Paulo");
            }
            else if (discagem == 21)
            {
                Console.WriteLine("Rio de Janeiro");
            }
            else if (discagem == 32)
            {
                Console.WriteLine("Juiz de Fora");
            }
            else if (discagem == 19)
            {
                Console.WriteLine("Campinas");
            }
            else if (discagem == 27)
            {
                Console.WriteLine("Vitoria");
            }
            else if (discagem == 31)
            {
                Console.WriteLine("Belo Horizonte");
            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }
        }
    }
}
