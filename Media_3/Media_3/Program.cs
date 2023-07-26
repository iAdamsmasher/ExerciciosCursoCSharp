using System;
using System.Globalization;

namespace Media_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, N4, media, notaExame, mediaExame; 
            string[] vet = Console.ReadLine().Split(' ');
            N1 = float.Parse(vet[0],CultureInfo.InvariantCulture);
            N2 = float.Parse(vet[1],CultureInfo.InvariantCulture);
            N3 = float.Parse(vet[2],CultureInfo.InvariantCulture);
            N4 = float.Parse(vet[3],CultureInfo.InvariantCulture);

            media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / (2 + 3 + 4 + 1);

            Console.WriteLine("Media = " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.",CultureInfo.InvariantCulture);
            }
            else if (media < 5)
            {
                Console.WriteLine("Aluno reprovado.", CultureInfo.InvariantCulture);
            }
            else if (media >= 5 && media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                notaExame = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                mediaExame = (notaExame + media) / 2;
                if (mediaExame >= 5)
                {
                    Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaExame.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Aluno reprovado");
                    Console.WriteLine("Media final: " + mediaExame.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
