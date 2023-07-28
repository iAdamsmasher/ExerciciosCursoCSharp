using System;


namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo1, tipo2, tipo3;

            tipo1 = Console.ReadLine();
            tipo2 = Console.ReadLine();
            tipo3 = Console.ReadLine();

            if (tipo1 == "vertebrado")
            {
                if (tipo2 == "ave")
                {
                    if (tipo3.Contains("carnivoro"))
                        Console.WriteLine("aguia");
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                  if (tipo3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (tipo2 == "inseto")
                {
                    if (tipo3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if(tipo3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
