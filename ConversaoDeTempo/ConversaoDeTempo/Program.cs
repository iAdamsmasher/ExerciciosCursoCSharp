using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoDeTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, minutos, segundos, N, resto;                                             // 1 min = 60s
            N = int.Parse(Console.ReadLine());                                                  // 1h = 60min = 3600s
            horas = N / 3600;                                                                   // % pega o resto da divisao de N por 3600s e 60s 
            resto = N % 3600;
            minutos = resto / 60;
            segundos = resto % 60;
            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
