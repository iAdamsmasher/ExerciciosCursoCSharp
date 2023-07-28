using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempoDeJogoComMinutos
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, minutoInicial, horaFinal, minutoFinal, instanteInicial, instanteFinal, duracao, duracaoHoras, duracaoMinutos;
           
            string[] hora = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(hora[0]);
            minutoInicial = int.Parse(hora[1]);
            horaFinal = int.Parse(hora[2]);
            minutoFinal = int.Parse(hora[3]);

            instanteInicial = horaInicial * 60 + minutoInicial;
            instanteFinal = horaFinal * 60 + minutoFinal;

            if (instanteInicial < instanteFinal)
            {
                duracao = instanteFinal - instanteInicial;
            }
            else
            {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }
            duracaoHoras = duracao / 60;
            duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        }
    }
}
