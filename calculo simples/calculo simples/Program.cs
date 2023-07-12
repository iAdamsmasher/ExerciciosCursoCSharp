using System;
using System.Globalization;

namespace calculo_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1, nPeca1, codigo2, nPeca2;
            double valor1, valor2, PAGAMENTO;

            string[] vet;
            vet = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(vet[0]);
            nPeca1 = int.Parse(vet[1]);
            valor1 = double.Parse(vet[2],CultureInfo.InvariantCulture);
            vet = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(vet[0]);
            nPeca2 = int.Parse(vet[1]);
            valor2 = double.Parse(vet[2],CultureInfo.InvariantCulture);

            PAGAMENTO = nPeca1 * valor1 + nPeca2 * valor2;
            

            Console.WriteLine("VALOR A PAGAR: R$ " + PAGAMENTO.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
