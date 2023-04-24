using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            int contador;

            Console.Write("Até qual número: ");
            contador = int.Parse(Console.ReadLine());

            for (double i = 1; i < contador; i++)
            {
                soma += 1 / i;
            }

            Console.WriteLine(soma);

            Console.ReadKey();
        }
    }
}
