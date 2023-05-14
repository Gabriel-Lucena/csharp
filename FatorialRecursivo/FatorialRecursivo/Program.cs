using System;

namespace FatorialRecursivo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FatorialRecursivo fatorialRecursivo = new FatorialRecursivo();

            int inteiro = 0;

            while (inteiro >= 0)
            {

                Console.Write("Digite um número: ");
                inteiro = int.Parse(Console.ReadLine());

                if (inteiro < 0) { break; }

                int fatorial = fatorialRecursivo.Fatorial(inteiro);

                Console.WriteLine(inteiro + " fatorial é " + fatorial);
            }

            Console.ReadKey();
        }
    }
}
