using System;
using System.Globalization;

namespace Vetores3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            //DECLARAÇÃO DOS VETORES
            string[] nome = new string[N];
            int[] idade = new int[N];
            double[] altura = new double[N];

            //LEITURA DOS DADOS
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                nome[i] = s[0];
                idade[i] = int.Parse(s[1]);
                altura[i] = double.Parse(s[2]);
            }

            //Calculo da altura média das pessoas

            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + altura[i];
            }
            double media;
            media = soma / N;

            Console.WriteLine("Altura Média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            //PORCENTAGEM DE PESSOAS ABAIXO DE 16 ANOS
            int cont = 0;

            for(int i =0; i<N; i++)
            {
                if(idade[i] < 16)
                {
                    cont++;
                }
            }
            double porcentagem = (double) cont / N * 100;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");

            Console.ReadLine();
        }
    }
}
