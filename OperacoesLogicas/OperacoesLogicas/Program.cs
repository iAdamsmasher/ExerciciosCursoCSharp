using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesLogicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoGasto, velocidadeMedia, distancia, litrosNecessarios;

            tempoGasto = int.Parse(Console.ReadLine());                                     //1km = 1000m
            velocidadeMedia = int.Parse(Console.ReadLine());                               //1h = 60min = 3600s

            tempoGasto = tempoGasto * 3600;

             
            distancia = velocidadeMedia * tempoGasto;

            litrosNecessarios = 12 * distancia;

            Console.WriteLine(distancia);
            Console.WriteLine(litrosNecessarios);

        }
    }
}
