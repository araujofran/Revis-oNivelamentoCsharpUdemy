using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisãoNivelamentoCsharpUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
                
                   
            Console.WriteLine ("Digite um nome: ");
            string frase = Console.ReadLine();
            Console.WriteLine("Digite um outro nome: ");
            string x = Console.ReadLine();
            Console.WriteLine("Digite um outro nome: ");
            string y = Console.ReadLine();
            Console.WriteLine("Digite um outro nome: ");
            string z = Console.ReadLine();
            Console.WriteLine("Digite três nomes na mesma linha: ");
            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
