using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Entrada_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            // string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            // string y = Console.ReadLine();
            //string z = Console.ReadLine();

            // string s = Console.ReadLine();   // 1º Jeito de se fazer Split
            // string[] Vet = s.Split(' ');
            // string a = Vet[0];
            //  string b = Vet[1];
            // string c = Vet[2];

            // string[] Vet2 = Console.ReadLine().Split(' ');  //2º Jeito de se fazer Split
            // string d = Vet2[0];
            // string e = Vet2[1];
            // string f = Vet2[2];

            // Console.WriteLine("Você digitou: ");
            // Console.WriteLine(frase);
            // Console.WriteLine(x);
            // Console.WriteLine(y);
            //Console.WriteLine(z);
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            //Console.WriteLine(c);
            // Console.WriteLine(d);
            // Console.WriteLine(e);
            //Console.WriteLine(f);

           // int n1 = int.Parse(Console.ReadLine());
           // char ch = char.Parse(Console.ReadLine());
           // double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            string s = Console.ReadLine();
            string[] v = s.Split(' ');
            string Name = v[0];
            char Caracter = char.Parse(v[1]);
            int Age = int.Parse(v[2]);
            double Stature = double.Parse(v[3], CultureInfo.InvariantCulture);





            //Console.WriteLine("Você digitou: ");
           // Console.WriteLine(n1);
           // Console.WriteLine(ch);
           // Console.WriteLine(n2.ToString("F1", CultureInfo.InvariantCulture));

            Console.WriteLine(Name);
            Console.WriteLine(Caracter);
            Console.WriteLine(Age);
            Console.WriteLine(Stature.ToString("F2", CultureInfo.InvariantCulture) + "m");
        }
    }
}
