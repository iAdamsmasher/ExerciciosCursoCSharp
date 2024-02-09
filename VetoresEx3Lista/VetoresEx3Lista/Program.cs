using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoresEx3Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());

            int[] vet1 = new int[N1];
            int[] vet2 = new int[N2];
            

            string[] leitura1 = Console.ReadLine().Split(' ');
            for (int i = 0; i < N1; i++)
            {
                vet1[i] = int.Parse(leitura1[i]);
            }

            string[] leitura2 = Console.ReadLine().Split(' ');
            for(int i = 0; i < N1; i++)
            {
                vet2[i] = int.Parse(leitura2[i]);
            }

            int[] vet3 = new int[vet1 + vet2];

        }
    }
}
